using UnityEngine;

public class PickUpObjectScript : MonoBehaviour{
    public bool isPick = false;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            isPick = true;
            Destroy(gameObject);
        }
    }
}
