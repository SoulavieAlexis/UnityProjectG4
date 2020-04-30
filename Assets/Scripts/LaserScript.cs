using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour{

    public LineRenderer monLinerRender;
    public float tailleLaser;

    public PickUpObjectScript pickUpObject;

    // Start is called before the first frame update
    void Start(){
        monLinerRender = GetComponent<LineRenderer>();
        monLinerRender.enabled = false;
    }
    // Update is called once per frame

    void Update(){
        RaycastHit2D rayonLaser = Physics2D.Raycast(transform.position, transform.up, tailleLaser);
        if(Input.GetButton("Fire1") && pickUpObject.isPick == true){
            monLinerRender.enabled = true;

            if(rayonLaser == true){
                monLinerRender.SetPosition(0, transform.position);
                monLinerRender.SetPosition(1, new Vector3(transform.position.x, transform.position.y + tailleLaser, transform.position.z));
            }else{
                Vector3 finLaser = new Vector3(transform.position.x, transform.position.y + tailleLaser, 0);

                monLinerRender.SetPosition(0, transform.position);
                monLinerRender.SetPosition(0, finLaser);
            }
        }else{
            monLinerRender.enabled = false;
        }
    }
}
