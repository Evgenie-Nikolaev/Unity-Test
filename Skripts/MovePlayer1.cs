using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MovePlayer1 : NetworkBehaviour
{
    bool facingRight = true;
    //transform Transforms = GetComponent<transform>();
    void Update()
    {
        if (isLocalPlayer)
        {
            Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            float speed = 4f * Time.deltaTime;
            transform.Translate(new Vector2(input.x * speed, input.y * speed));
            Animator animator = GetComponent<Animator>();
            if(input.x == 0 && input.y == 0)
            {
                animator.SetBool("Wolk", false);
            }
            else
            {
                animator.SetBool("Wolk", true);
            }
            if(!facingRight && input.x > 0)
            {
                flip();
            }
            else if(facingRight && input.x < 0)
            {
                flip();
            }

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
