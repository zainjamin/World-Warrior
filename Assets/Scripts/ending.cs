using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    endScreen endThing;
    Dialogue poo;
    string[] lines;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject.FindGameObjectWithTag("weirdTag").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    }
}
