using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetText : MonoBehaviour
{
    public Text bro;
    private void Start()
    {
        bro = GetComponent<Text>();
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "park")
            bro.text = "Objective: \n Take your car home. \n \n Optional: \n Pick up and sort garbage.";
        else if (SceneManager.GetActiveScene().name == "city")
            bro.text = "Objective: \n Take the bus or your car to the park \n \n Optional: Pick up trash and bring it to the garbage can \n Use E to interact with objects";
    }
}
