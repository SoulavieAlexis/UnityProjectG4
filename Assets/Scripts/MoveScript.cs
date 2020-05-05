using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class MoveScript : MonoBehaviour
{
    // 1 - Designer variables

    /// <summary>
    /// Object speed
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(1, 1);


    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    private float starShipPositionX;


    void Update()
    {
        starShipPositionX = this.transform.position.x;
        
        if (starShipPositionX <= 9 || starShipPositionX >= 10)
        {
            // 2 - Movement
            movement = new Vector2(
              -speed.x * direction.x,
              speed.y * direction.y);
        }
        else
        {
            // 2 - Movement
            movement = new Vector2(
              speed.x * direction.x,
              speed.y * direction.y);
        }
        
    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }
}