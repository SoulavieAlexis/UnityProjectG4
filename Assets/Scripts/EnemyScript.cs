using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Comportement générique pour les méchants
/// </summary>
public class EnemyScript : MonoBehaviour
{
    private WeaponScript[] weapons;
    private Renderer m_Renderer;

    void Awake()
    {
        // Récupération de toutes les armes de l'ennemi
        weapons = GetComponentsInChildren<WeaponScript>();
        m_Renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (m_Renderer.isVisible)
        {
            foreach (WeaponScript weapon in weapons)
            {
                // On fait tirer toutes les armes automatiquement
                if (weapon != null && weapon.CanAttack)
                {
                    weapon.Attack(true);
                }
            }
        }
    }
}
