using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : Interactables
{
    public override void Update()
    {
        base.Update();
        if (interactController.startDialogue && Input.GetKeyDown(KeyCode.F))
        {
            interactController.startDialogue = false;
            hideBox();
            FindObjectOfType<SceneController>().nextScene();
        }

    }

    protected override void interact()
    {
        if (!interactController.startDialogue)
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
