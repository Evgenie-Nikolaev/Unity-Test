using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class garbageCollection : MonoBehaviour
{
    public AudioSource au;
    public Text text;
    public int garbage = 0;
    private void Update()
    {
        text.text = garbage.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("garbage"))
        {

            au.Play();
            garbage += Random.Range(0, 4);
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("garbage", garbage);
        }
    }
}
