using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerUnquesteble : MonoBehaviour
{
    public Dialog dialogDef;                   //создание диалоgа класа диалог
    public Animator boxAnim;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<DialogManager>().StartDialog(dialogDef);
        }
    }

    public void OnTriggerExit2D(Collider2D other){
        boxAnim.SetBool("isOpen", false);
    }
}
