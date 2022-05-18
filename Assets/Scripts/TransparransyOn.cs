using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparransyOn : MonoBehaviour
{
    GameObject player;
    public GameObject roof;
    public Color oldColor;
    public Material roofColor;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
        roof = gameObject;
        roofColor = roof.GetComponent<Renderer>().material;
    }

    void OnTriggerEnter2D (Collider2D other){
        if(other.gameObject == player){
            Color oldColor = roofColor.color;
            Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 0.75f);
            roofColor.SetColor("_Color", newColor);
        }
    }

    void OnTriggerExit2D (Collider2D other){
        if(other.gameObject == player){
            Color oldColor = roofColor.color;
            Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, 1f);
            roofColor.SetColor("_Color", newColor);
        }
    }
}
