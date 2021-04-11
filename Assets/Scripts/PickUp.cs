using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

   /* private void OnMouseDown()
    { 
       
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i]== false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(item, inventory.slots[i].transform,false);
                    Destroy(gameObject);
                    break;
                }
            }
     
    } */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(item, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}

