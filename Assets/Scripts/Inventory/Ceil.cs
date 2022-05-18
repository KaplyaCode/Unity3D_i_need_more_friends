using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceil : MonoBehaviour
{
    private InaventoryManager inventory;
    public int i;

    private void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InaventoryManager>();
    }

    private void Update(){
        if(transform.childCount <= 0){
            inventory.isFull[i] = false;
        }
    }

    public void DropItem(){
        foreach (Transform child in transform)
        {
            child.GetComponent<Drop>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
