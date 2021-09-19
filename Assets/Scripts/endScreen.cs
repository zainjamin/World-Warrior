using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScreen : Interactables
{
    string[] sents = new string[8];

    public void Start()
    {
        sents[0] = "You picked up " + (100*interactController.totalCount/22) + "% of garbage, and sorted it " + (interactController.totalCount > 0 ? 100*interactController.correctCount/ interactController.totalCount : 0) + "% correctly";
        sents[1] = "In toronto, 26% of recycling is sorted incorrectly, and costs Canada millions of ";
        sents[2] = "dollars to manage it.";
        sents[3] = "You chose to " + (interactController.tookBus ? "take the bus " : "drive your car ") + " to get to the park.";
        sents[4] = "Using public transportation decreases your carbon footprint considerably.";
        sents[5] = "Each full TTC bus saves 70,000 litres of fuel and effectively "; 
        sents[6] = "removes nine tonnes of pollutants from the air each year.";
        sents[7] = "Your choices matter in this world, a world that you can save.";
        interact();
    }

    protected override void interact()
    {
        dialogue.name = "???";
        dialogue.sentences = sents;
        if (!interactController.startDialogue)
        {
            Debug.Log("Test");
            interactController.startDialogue = true;
            FindObjectOfType<DialogueManager>().box.SetActive(true);
            TriggerDialogue();
        }
        else
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }


}
