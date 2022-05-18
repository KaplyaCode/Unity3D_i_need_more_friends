using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallTriggerScript : MonoBehaviour
{
    GameObject player;
    public AudioReverbZone roomZone;
    public AudioSource birdSound;
    public AudioSource roadSound;
    public AudioSource roadSound2;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D (Collider2D other){
        if(other.gameObject == player){
            roomZone.enabled = true;
        }
    birdSound.volume = 0.003f;
    roadSound.mute = true;
    roadSound2.mute = true;
    }

    void OnTriggerExit2D (Collider2D other){
        if(other.gameObject == player){
            roomZone.enabled = false;
        }
        birdSound.volume = 0.03f;
        roadSound.mute = false;
        roadSound2.mute = false;
    }
}
