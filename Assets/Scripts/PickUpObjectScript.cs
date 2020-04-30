using UnityEngine;

public class PickUpObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPick = false;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            isPick = true;
            Destroy(gameObject);
        }
    }
}
