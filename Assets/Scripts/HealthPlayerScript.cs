using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayerScript : MonoBehaviour
{
    //Points de vie du player
    public int maxHealth = 100;
    public int currentHealth;

    public bool isEnemy;
    public bool powerLaser;

    //On récupère la barre de vie
    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
        powerLaser = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
        PlayerScript player = collider.gameObject.GetComponent<PlayerScript>();
        EnemyScript enemy = collider.gameObject.GetComponent<EnemyScript>();
        PickUpObjectScript pickUpObject = collider.gameObject.GetComponent<PickUpObjectScript>();
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
        //Si le joueur prend lifeItem, il récupère de la vie
        if(pickUpObject != null && pickUpObject.isLife == true )
        {
            healPlayer(50);
        }

        if (pickUpObject != null && pickUpObject.isLaser == true)
        {
            powerLaser = true;
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }

    //Le player récupère de la vie
    void healPlayer(int health)
    {
        currentHealth += health;
        if (currentHealth > maxHealth)
        {
            currentHealth = 100;
        }
        healthBar.SetHealth(currentHealth);

    }
}
