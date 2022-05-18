using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatTrigger : MonoBehaviour
{
    AudioSource catSound;
    public AudioClip maow;

    public void Start(){
        catSound = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            catSound.PlayOneShot(maow);
        }
    }
}
