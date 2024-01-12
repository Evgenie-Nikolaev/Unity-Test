using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveOffline : MonoBehaviour
{
    public GameObject im;

    bool facingRight = true;

    public Image staminaIm;
    public Image HPBar;

    public bool canShift = true;
    public float stamina = 3;

    public float speed = 4f;

    public float HP = 7f;

    public OutOlanets Out;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            HP -= 1;
        }
    }
    
    

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(2);

    }
    void Update()
    {
        if(HP <= 0)
        {
            Out.dayes -= 1;
            im.SetActive(true);
            StartCoroutine(Dead());
        }
        HPBar.fillAmount = HP / 7f;
        staminaIm.fillAmount = stamina / 3;
        if (stamina <= 0)
        {
            canShift = false;
        }
        if (stamina > 0)
        {
            canShift = true;
        }
 
        if (Input.GetKey(KeyCode.LeftShift) && canShift)
        {
            speed = 5f;
            stamina -= Time.deltaTime;
        }
        else
        {
            if (stamina < 3)
            {
                stamina += Time.deltaTime;
            }
            speed = 3f;
        }
        

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        transform.Translate(new Vector2(input.x * speed * Time.deltaTime, input.y * speed * Time.deltaTime));
        Animator animator = GetComponent<Animator>();
        if (input.x == 0 && input.y == 0)
        {
            animator.SetBool("Wolk", false);
        }
        else
        {
            animator.SetBool("Wolk", true);
        }
        if (!facingRight && input.x > 0)
        {
            flip();
        }
        else if (facingRight && input.x < 0)
        {
            flip();
        }


    }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
         Scale.x *= -1;
         transform.localScale = Scale;
    }
}
