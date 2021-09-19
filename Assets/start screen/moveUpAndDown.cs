using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    bool moved;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 0.33f)
        {
            rb.velocity = new Vector2(0, -0.5f);
        }else if(transform.position.y < -0.33)
        {
            rb.velocity = new Vector2(0, 0.5f);
        }
    }




}
