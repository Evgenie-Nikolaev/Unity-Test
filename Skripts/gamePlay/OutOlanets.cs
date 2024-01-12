using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OutOlanets : MonoBehaviour
{
    public float time24 = 600;

    public Text textf;

    public Text day;

    public int dayes = 3; 
    
    void Update()
    {
        day.text = dayes.ToString();
        textf.text = ((int)time24).ToString();
        time24 -= Time.deltaTime;
        if(time24 <= 0)
        {
            Out();
        }
    }

    public void Out()
    {
        SceneManager.LoadScene(2);
        dayes -= 1;
    }
}
