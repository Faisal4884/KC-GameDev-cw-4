using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day5 : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed;
    float playerInput;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * speed, 0);
    }
}