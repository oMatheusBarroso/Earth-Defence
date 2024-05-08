﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mediumAsteroidMov : MonoBehaviour
{
    private float mediumAsteroidMoveSpeed = 2.5f;

    private Vector2 movement;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var direction = new Vector3(0, 0, 0) - transform.position; // direção em que o asteroid irá se mover (centro da tela)
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveAsteroid(movement);
    }

    public void MoveAsteroid(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * mediumAsteroidMoveSpeed * Time.deltaTime));
    }
}
