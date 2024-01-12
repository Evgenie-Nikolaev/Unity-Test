using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cvota : MonoBehaviour
{
    public Text oo;
    public int cvota = 0;

    public int lCvota = 35;

    public GameObject DedLine;

    public OutOlanets Out;

    void Start()
    {
        if(PlayerPrefs.HasKey("garbage"))
        {
            cvota = PlayerPrefs.GetInt("garbage");
        }

    }

    void Update()
    {
        if (lCvota <= cvota)
        {
            cvota = 0;
            PlayerPrefs.SetInt("garbage", cvota);
        }
        if(lCvota > cvota && Out.dayes >= 0)
        {
            DedLine.SetActive(true);
        }

        oo.text = cvota.ToString();
    }
}
