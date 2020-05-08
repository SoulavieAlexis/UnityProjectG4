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
            GetComponent<HealthScript>().isEnemy = true;
            Debug.Log(GetComponent<HealthScript>().isEnemy);
        }
        else
        {
            GetComponent<HealthScript>().isEnemy = false;
            Debug.Log(GetComponent<HealthScript>().isEnemy);
        }
        
        
    }
}
