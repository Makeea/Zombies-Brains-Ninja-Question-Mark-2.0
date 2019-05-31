using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float speed;

    private Rigidbody2D myRigidbody;

    private Vector2 direction;

    // Use this for initialization
    void Start()
    {
      myRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = direction * speed;
        //direction = Vector2.right;

    }

    public void Initialize(Vector2 direction)
    {
        this.direction = direction;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}