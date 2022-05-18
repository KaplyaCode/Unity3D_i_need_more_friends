using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text nodeText;

    public Animator boxAnim;

    public Text tasks;

    private Queue<string> sentences;

    private void Start(){
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog){
        boxAnim.SetBool("isOpen", true);
        
        nameText.text = dialog.name;
        sentences.Clear();

        foreach(string sentence in dialog.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence){
        nodeText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            nodeText.text +=letter;
            yield return null;
        }
    }


    public void EndDialog(){
        boxAnim.SetBool("isOpen", false);
    }
}
