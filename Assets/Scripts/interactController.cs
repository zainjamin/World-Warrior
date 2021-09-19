using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] interactables;
    public static GameObject selected;
    public float[] distanceFrom;
    public static bool startDialogue;
    [SerializeField] float interactDist;
    [SerializeField] GameObject player;
    public static int trashCount, totalCount, correctCount;
    public static bool tookBus;

    void Start()
    {
        trashCount = 0;
        totalCount = 0;
        correctCount = 0;
        tookBus = false;
    }

    // Update is called once per frame
    void Update()
    {
        interactables = GameObject.FindGameObjectsWithTag("Interactables");
        distanceFrom = new float[interactables.Length];

     
        for (int i = 0; i < interactables.Length; i++)
        {
            distanceFrom[i] = (interactables[i].transform.position - player.transform.position).magnitude;

            if (distanceFrom[i] > interactDist)
            {
                Debug.DrawRay(player.transform.position, interactables[i].transform.position - player.transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(player.transform.position, interactables[i].transform.position - player.transform.position, Color.red);

            }
        }

        if(interactables.Length > 0)
        {
            select();
        }
     

 
    }

    int findClosest()
    {
        int smallest = 0;
        if (distanceFrom.Length > 0)
        {
            for (int i = 0; i < distanceFrom.Length; i++)
            {
                if (distanceFrom[smallest] > distanceFrom[i])
                {
                    smallest = i;
                }
            }
        }
        return smallest;
    }

    void select()
    {
        if (distanceFrom[findClosest()] < interactDist)
        {
            selected = interactables[findClosest()];
            Debug.DrawLine(interactables[findClosest()].transform.position, new Vector3(0, 1, 0), Color.yellow);
        }
        else
        {
            selected = null;
        }
    }

}