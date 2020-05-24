using UnityEngine;

public class PickUpObjectScript : MonoBehaviour{
    //Type d'objet
    public bool isLaser = false;
    public bool isLife = false;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            if (gameObject.CompareTag("laserItem"))
            {
                isLaser = true;
            }
            else if(gameObject.CompareTag("lifeItem"))
            {
                isLife = true;
            }
            Destroy(gameObject);
        }
    }
}
