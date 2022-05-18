using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAnimator : MonoBehaviour
{
    public Animator boxAnim;
    public DialogManager dm;

    public void OnCollisionEnter2D(Collision2D other){
        boxAnim.SetBool("isOpen", true);
    }

    public void OnCollisionExit2D(Collision2D other){
        boxAnim.SetBool("isOpen", false);
        dm.EndDialog();
    }
}
