using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayerScript : MonoBehaviour
{
    //Points de vie du player
    public int maxHealth = 100;
    public int currentHealth;

    public bool isEnemy;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
        PlayerScript player = collider.gameObject.GetComponent<PlayerScript>();
        EnemyScript enemy = collider.gameObject.GetComponent<EnemyScript>();
        if (shot != null)
        {
            // Tir allié
            if (shot.isEnemyShot != isEnemy)
            {
                currentHealth -= shot.damage;
                TakeDamage(shot.damage);

                // Destruction du projectile
                // On détruit toujours le gameObject associé
                // sinon c'est le script qui serait détruit avec ""this""
                Destroy(shot.gameObject);

                if (currentHealth <= 0)
                {
                    // Destruction !
                    Destroy(gameObject);
                }
            }
        }
        // Si Le joueur touche un ennemi, cet ennemi est détruit
        if (player != null)
        {
            Destroy(gameObject);
        }

        // Si le joueur touche un ennemi il perd 2 hp
        if (enemy != null && this.isEnemy == false)
        {
            currentHealth -= 20;
            TakeDamage(20);

            if (currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
        void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }
}
