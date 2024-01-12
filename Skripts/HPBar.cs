using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    Image helthBar;
    public float maxHealth = 100f;
    public float HP;
    // Start is called before the first frame update
    void Start()
    {
        helthBar = GetComponent<Image>();
        HP = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        helthBar.fillAmount = HP / maxHealth;
    }
}
