using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAnimation : MonoBehaviour
{
    private Animator anim;
    
    void Start(){
        anim = GetComponent<Animator>();
    }

    void Update(){
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)){
            anim.SetBool("isRuningRight", true);
        }else{
            anim.SetBool("isRuningRight", false);
        }
        
        if(Input.GetKey(KeyCode.W)){
            anim.SetBool("isRuningTop", true);
        }else{
            anim.SetBool("isRuningTop", false);
        }

        if(Input.GetKey(KeyCode.S)){
            anim.SetBool("isRuningBottom", true);
        }else{
            anim.SetBool("isRuningBottom", false);
        }
    }
}
