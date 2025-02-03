using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    private Transform player;
    public static int Coins = 0;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        float CoinDistance = Vector3.Distance(transform.position, player.position);
        if (CoinDistance <= 2)
        {
            Coins++;
            Destroy(coin);
        }
    }
}
