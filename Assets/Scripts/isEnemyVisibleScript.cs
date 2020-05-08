using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isEnemyVisibleScript : MonoBehaviour
{

    private Renderer m_Renderer ;

    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    
    void Update()
    {
        if (m_Renderer.isVisible)
        {
<<<<<<< HEAD
            GetComponent<HealthScript>().isEnemy = true;
            Debug.Log(GetComponent<HealthScript>().isEnemy);
=======
            GetComponent<HealthScript>().isEnemy = true; 
>>>>>>> parent of 928b395... limité à la zone de la caméra
        }
        else
        {
            GetComponent<HealthScript>().isEnemy = false;
        }
        
        
    }
}
