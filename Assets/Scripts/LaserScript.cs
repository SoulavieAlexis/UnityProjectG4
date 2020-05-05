using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour{

    public LineRenderer monLinerRender;
    public float tailleLaser;

    //On recupere les variables du script 
    public PickUpObjectScript pickUpObject;

    //Temps du pouvoir
    private int powerTime;

    // Start is called before the first frame update
    void Start(){
        monLinerRender = GetComponent<LineRenderer>();
        monLinerRender.enabled = false;
        powerTime = 150;
    }
    // Update is called once per frame

    void Update(){
        RaycastHit2D rayonLaser = Physics2D.Raycast(transform.position, transform.up, tailleLaser);
    
        if(Input.GetButton("Fire1") && pickUpObject.isPick == true && powerTime > 0){
            powerTime -= 1;
            monLinerRender.enabled = true;
            if(rayonLaser == true){
                monLinerRender.SetPosition(0, transform.position);
                monLinerRender.SetPosition(1, rayonLaser.point);

                if(rayonLaser.collider.tag == "Ennemi"){
                    //On récupère la fonction d'healhscript
                    rayonLaser.collider.GetComponent<HealthScript>().damageLaser(1);
                }
            }else{
                Vector3 finLaser = new Vector3(transform.position.x, transform.position.y + tailleLaser, 0);

                monLinerRender.SetPosition(0, transform.position);
                monLinerRender.SetPosition(1, finLaser);
            }
        }else{
            monLinerRender.enabled = false;
        }
    }
}
