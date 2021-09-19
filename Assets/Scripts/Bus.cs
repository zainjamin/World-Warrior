using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : Interactables
{
    public override void Update()
    {
        base.Update();
        if (interactController.startDialogue && Input.GetKeyDown(KeyCode.F))
        {
            interactController.startDialogue = false;
            hideBox();
            interactController.tookBus = true;
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
