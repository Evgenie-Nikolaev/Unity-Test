using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shover : MonoBehaviour
{

    private float time;

    public float startTime;

    public AudioSource au;

    public Animator anim;
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.66f);
        anim.SetBool("Hit", false);
    }
    void Update()
    {

        Vector3 distens = Camera.main.ScreenToViewportPoint(Input.mousePosition);// - transform.position;
        float rotate = Mathf.Atan2(distens.y, distens.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotate - 90);


        if(time <= 0f)
        {
            if(Input.GetMouseButtonDown(0))
            {
                au.Play();
                time = startTime;
                anim.SetBool("Hit", true);
                StartCoroutine(Wait());
            }
            else
            {
                time -= startTime;
            }
        }
    }
}
