using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Vector2 movement;
    public float moveSpeed;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg + 180;
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (rb.velocity.magnitude == 0)
        {
            animator.SetBool("idle", true);
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        else
        {
            animator.SetBool("idle", false);

            if (Input.GetKey(KeyCode.A)) //                                                             D:
            {
                animator.SetBool("left", true);
            }
            else
            {
                animator.SetBool("left", false);
            }

            if (Input.GetKey(KeyCode.D))
            {
                animator.SetBool("right", true);
            }
            else
            {
                animator.SetBool("right", false);
            }


            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("up", true);
            }
            else
            {
                animator.SetBool("up", false);
            }

            if (Input.GetKey(KeyCode.S))
            {
                animator.SetBool("down", true);
            }
            else
            {
                animator.SetBool("down", false);
            }

        }








    }

    private void FixedUpdate()
    {
        if (!interactController.startDialogue)
            rb.velocity = movement * moveSpeed;
        else rb.velocity = new Vector2(0,0);
    }



}