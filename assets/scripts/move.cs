using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool canJump = false;
    public float speed = 1f;
    public float maxSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.D)) {
            rb.AddForce(Vector2.right*speed);
        }
        if (Input.GetKey (KeyCode.A)) {
            rb.AddForce(Vector2.left*speed);
        }
        if (Input.GetKey (KeyCode.W) && canJump == true) {
            canJump = false;
            rb.AddForce(Vector3.up*15,ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D c){
        if (c.collider.tag == "ground"){
            canJump = true;
        }
    }
    void FixedUpdate (){
            if (rb.velocity.magnitude > maxSpeed) {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
        }
}
