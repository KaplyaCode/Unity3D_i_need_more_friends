using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;                   //создание диалоgа класа диалог
    public Dialog questDone;

    public AudioClip[] pencil;

    AudioSource playerAudio;

    public int items;
    
    private bool numerator = true;

    public Text tasks;

    public void Start(){
        playerAudio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag != "Player" && other.gameObject.GetComponent<PickUp>().id == items)
        {
            playerAudio.PlayOneShot(pencil[1]);

            dialog = questDone;
            numerator = false;

            FindObjectOfType<DialogManager>().StartDialog(dialog);
            Destroy(other.gameObject);

            tasks.text = "> Enter to elevator";
        }
    }

    public void OnCollisionExit2D(Collision2D other){
        if(numerator)
            {
            numerator = false;
            tasks.text = "> Enter to elevator\n> Find a bread for security";
            playerAudio.PlayOneShot(pencil[0]);
            }
    }

    public void OnCollisionEnter2D(Collision2D other){
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
