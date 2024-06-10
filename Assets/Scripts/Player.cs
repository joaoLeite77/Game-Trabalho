using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    public Rigidbody2D rig;
    private Animator animator;
    private bool isJumping;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rig.velocity = new Vector2(Speed, rig.velocity.y);

        if (Input.GetMouseButtonDown(0) && !isJumping){

            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;

        }

    }

    private void OnCollisionEnter2D(Collision2D colisor)
    {

        if (colisor.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }
}
