using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : Interactables
{

    private void Start()
    {
        type = "trash can";
    }
    protected override void interact()
    {
        if (!interactController.startDialogue && interactController.trashCount > 0)
        {
            interactController.trashCount--;
            FindObjectOfType<DialogueManager>().prompt.SetActive(true);
            FindObjectOfType<ImageManager>().changeImage();
        }
        else if(!interactController.startDialogue && interactController.trashCount == 0)
        {
            interactController.startDialogue = true;
            showBox();
            TriggerDialogue();
        }
        else
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
                      
    }
}
