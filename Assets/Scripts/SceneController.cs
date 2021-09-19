using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] int currentScene;
    [SerializeField] GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && currentScene == 0)
        {
            nextScene();
        }
    }

    public void nextScene()
    {
        currentScene++;
        SceneManager.LoadScene(currentScene);
        player.transform.position = new Vector3(0, 0, 0);
    }
}
