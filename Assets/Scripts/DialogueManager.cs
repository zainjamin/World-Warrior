using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;
    public GameObject box;
    public GameObject prompt;
    public char ans;
    bool lollers;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        box.SetActive(false);
        prompt.SetActive(false);
    }


    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.01666f);

        }
    }

    public void EndDialogue()
    {
        Debug.Log("End conversation");
        if (lollers)
        {
            Debug.Log("looooooofeet");
            Application.Quit();
        }
        if(SceneManager.GetActiveScene().name != "ending")
        {
            interactController.startDialogue = false;
            FindObjectOfType<DialogueManager>().box.SetActive(false);

        }
        else
        {
            lollers = true;
        }
        if(interactController.selected.GetComponent<Interactables>().type == "trash")
        {
            Destroy(interactController.selected);
        }
        
        
    }

    public void recycle()
    {
        interactController.startDialogue = true;
        ans = 'r';
        bool correct = FindObjectOfType<ImageManager>().checkAns(ans);
        FindObjectOfType<DialogueManager>().prompt.SetActive(false);
        if (correct)
        {
            string[] sentences = new string[1];
            sentences[0] = "You correctly sorted the trash. You helped the environment.";
            Dialogue response = new Dialogue("Trash Can", sentences);
            interactController.correctCount++;
            box.SetActive(true);
            StartDialogue(response);
        }
        else
        {
            string[] sentences = new string[1];
            sentences[0] = "You incorrectly sorted the trash. You harmed the environment.";
            Dialogue response = new Dialogue("Trash Can", sentences);
            box.SetActive(true);
            StartDialogue(response);
        }
    }

    public void garbage()
    {
        interactController.startDialogue = true;
        ans = 'g';
        bool correct = FindObjectOfType<ImageManager>().checkAns(ans);
        FindObjectOfType<DialogueManager>().prompt.SetActive(false);
        if (correct)
        {
            string[] sentences = new string[1];
            sentences[0] = "You correctly sorted the trash. You helped the environment.";
            Dialogue response = new Dialogue("Trash Can", sentences);
            interactController.correctCount++;
            box.SetActive(true);
            StartDialogue(response);
        }
        else
        {
            string[] sentences = new string[1];
            sentences[0] = "You incorrectly sorted the trash. You harmed the environment.";
            Dialogue response = new Dialogue("Trash Can", sentences);
            box.SetActive(true);
            StartDialogue(response);
        }
    }
}
