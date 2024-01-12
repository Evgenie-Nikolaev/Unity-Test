using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private inventari inventari;
    public GameObject slotButton;

    private void Start()
    {
        inventari = GameObject.FindGameObjectWithTag("Player").GetComponent<inventari>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            for (int i=0; i < inventari.slots.Length; i++)
            {
                if(inventari.isFull[i] == false)
                {
                    inventari.isFull[i] = true;
                    Instantiate(slotButton, inventari.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
