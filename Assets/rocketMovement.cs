using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    private float moveSpeed = 750;
    public Rigidbody2D rocket;

    // Start is called before the first frame update
    void Start()
    {
        rocket = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Move the rocket only along the x-axis
        Vector2 movement = new Vector2(horizontalInput, 0f) * moveSpeed * Time.deltaTime;
        rocket.MovePosition(rocket.position + movement);
    }
}
