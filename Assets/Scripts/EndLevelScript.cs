using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelScript : MonoBehaviour
{
    public Animator anim;

    public void OnTriggerEnter2D(Collider2D other){
        anim.SetBool("isOpen", true);
    }

    public void OnTriggerExit2D(Collider2D other){
        anim.SetBool("isOpen", false);
    }
}
