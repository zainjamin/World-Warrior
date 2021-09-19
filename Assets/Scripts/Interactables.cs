using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public Dialogue dialogue;
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        interactController.startDialogue = false;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (interactController.selected == gameObject && Input.GetKeyDown(KeyCode.E))
        {
            interact();
        }
    }


    protected virtual void interact()
    {
        Debug.Log("big monkey feet");
    }
        
    public virtual void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public virtual void hideBox()
    {
        FindObjectOfType<DialogueManager>().box.SetActive(false);
    }

    public virtual void showBox()
    {
        FindObjectOfType<DialogueManager>().box.SetActive(true);
    }
}
