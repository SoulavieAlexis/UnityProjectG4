using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour {
    public string levelname= "enter level name here";
    private void OnTrigerEnter2D(Collider2D other) {
      
      if (other.tag == "player")
      {
          Application.LoadLevel(levelname);
      }
    }
}
 
