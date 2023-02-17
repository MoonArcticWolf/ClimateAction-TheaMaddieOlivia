using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public Animator animator;

    void Start()
    {
        sentences = new Queue<string>();
    }
    public void startDialogue(Dialogue dialogue){
        animator.SetBool("isOpen", true);
        Debug.Log("conversing with" + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        displayNextSentence();
    }
    public void displayNextSentence()
    {
        if (sentences.Count == 0){
            endDialogue();
            return;

        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(typeSentence(sentence));
    }
    IEnumerator typeSentence(string sentence){
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()){
            dialogueText.text += letter;
            yield return null;
        }
    }
    void endDialogue()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("ending conversation");
    }
}
