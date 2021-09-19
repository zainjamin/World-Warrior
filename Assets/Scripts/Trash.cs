using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : Interactables
{
    private void Start()
    {
        type = "trash";
    }
    protected override void interact()
    {
        Debug.Log("interact");
        if (interactController.startDialogue == false)
        {
            interactController.trashCount++;
            interactController.totalCount++;
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
