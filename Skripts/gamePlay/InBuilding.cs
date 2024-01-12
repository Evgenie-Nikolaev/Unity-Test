using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBuilding : MonoBehaviour
{
    public GameObject ButtonE;
    public Transform player;
    public float X, Y,X1,Y1;

    public AudioSource Doors;
    public AudioSource DoorsOut;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void InBild()
    {
        Doors.Play();
        player.position = new Vector3(X, Y, 0);
    }
    public void OutBild()
    {
        DoorsOut.Play();
        player.position = new Vector3(X1, Y1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ButtonE.SetActive(true);
        }
    }
    
private void OnTriggerExit2D(Collider2D collision)
    {

        ButtonE.SetActive(false);
    }
}
