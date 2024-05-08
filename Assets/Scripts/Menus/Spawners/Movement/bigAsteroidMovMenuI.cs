using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigAsteroidMovMenuI : MonoBehaviour
{
    public Vector3 Destination;

    private float bigAsteroidMoveSpeed = 1.8f;

    private Vector2 movement;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = Destination - transform.position; // direção em que o asteroid irá se mover (centro da tela)
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveAsteroid(movement);
    }

    public void MoveAsteroid(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * bigAsteroidMoveSpeed * Time.deltaTime));
    }
}
