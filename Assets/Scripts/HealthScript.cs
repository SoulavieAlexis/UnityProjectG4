using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gestion des points de vie et des dégâts
/// </summary>
public class HealthScript : MonoBehaviour
{
    /// <summary>
    /// Points de vies
    /// </summary>
    public int hp;

    /// <summary>
    /// Ennemi ou joueur ?
    /// </summary>
    public bool isEnemy;


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
                hp -= shot.damage;
                

                // Destruction du projectile
                // On détruit toujours le gameObject associé
                // sinon c'est le script qui serait détruit avec ""this""
                Destroy(shot.gameObject);

                if (hp <= 0)
                {
                    //Ajout de 50 points au score
                    ScoreScript.instance.addPoints(50);
                    // Destruction !
                    Destroy(gameObject);
                }
            }
        }
        // Si Le joueur touche un ennemi, cet ennemi est détruit
        if (player != null)
        {
            ScoreScript.instance.addPoints(50);
            Destroy(gameObject);
        }

        // Si le joueur touche un ennemi il perd 2 hp
        if (enemy != null && this.isEnemy == false)
        {
            hp -= 2;

            if (hp <= 0)
            {
                ScoreScript.instance.addPoints(50);
                Destroy(gameObject);
            }
        }
    }
// DEgats du laser
    public void damageLaser(int damage){
        hp = hp - damage;
        if(hp <= 0){
            ScoreScript.instance.addPoints(50);
            Destroy(this.gameObject);
        }
    }
}
