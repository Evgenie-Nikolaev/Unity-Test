using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private inventari inventari;
    public int i;

    private void Start()
    {
        inventari = GameObject.FindGameObjectWithTag("Player").GetComponent<inventari>();
    }
    private void Update()
    {
        if(transform.childCount <=0)
        {
            inventari.isFull[i] = false;
        }
    }
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<SpawnInv>().SpawnDroppenItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
