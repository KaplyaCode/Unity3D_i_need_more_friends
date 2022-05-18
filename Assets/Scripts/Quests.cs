using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public int questNumber;
    public int[] items;

    public void OnTriggerEnter2D(Collider2D other){
        if(other.tag != "Player" && other.gameObject.GetComponent<PickUp>().id == items[questNumber]){
            questNumber++;
            Destroy(other.gameObject);
        }
    }
}
