using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private InaventoryManager inventory;
    public GameObject inceil;
    public int id;

    private void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<InaventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            for( int i = 0; 1 < inventory.ceil.Length; i++){
                if(inventory.isFull[i] == false){
                    inventory.isFull[i] = true;
                    Instantiate(inceil, inventory.ceil[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
