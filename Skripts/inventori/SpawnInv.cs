using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInv : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void SpawnDroppenItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 1, player.position.y - 0);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
