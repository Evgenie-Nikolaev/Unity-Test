using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DephDeadScene : MonoBehaviour
{
    public GameObject im;

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(2);

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            im.SetActive(true);
            StartCoroutine(Dead());


        }
        
    }
}
