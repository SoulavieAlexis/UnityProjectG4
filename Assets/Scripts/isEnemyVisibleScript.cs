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
            GetComponent<BoxCollider2D>().enabled = true;
            
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log(GetComponent<HealthScript>().hp);
        }
        
        
    }
}
