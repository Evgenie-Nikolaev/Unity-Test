using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider1 : MonoBehaviour
{
    public float speed;
    public int Patryl;
    public Transform point;
    public bool moving1;

    bool cill1 = false;
    bool Angry1 = false;
    bool GaBak1 = false;

    public int hp = 3;

    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, point.position) < Patryl && Angry1 == false)
        {
            cill1 = true;
        }

        if (Vector2.Distance(transform.position, player.position) < Patryl)
        {
            Angry1 = true;
            cill1 = false;
            GaBak1 = false;
        }
        if (Vector2.Distance(transform.position, player.position) > Patryl)
        {
            GaBak1 = true;
            Angry1 = false;
        }
        if (cill1)
        {
            Chill();
        }
        else if (Angry1)
        {
            Anrgy();
        }
        else if (GaBak1)
        {
            GoBak();
        }
    }
    void Chill()
    {
        if (transform.position.y > point.position.y + Patryl)
        {
            moving1 = false;

        }
        else if (transform.position.y < point.position.y - Patryl)
        {
            moving1 = true;
        }
        if (moving1)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }

        if(hp <= 0)
        {
            Destroy(gameObject);
        }


    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Hit"))
        {
            hp -= 1;
        }
    }
    void Anrgy()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
    void GoBak()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }
}
