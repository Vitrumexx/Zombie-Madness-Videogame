using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Carrot : MonoBehaviour
{
    public GameObject carrot;
    private Transform player;
    public static int Carrots;
    void Start()
    {
        Carrots = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float CarrotDistance = Vector3.Distance(transform.position, player.position);
        if (CarrotDistance <= 5 && Input.GetKeyDown(KeyCode.E))
        {
            Carrots++;
            Destroy(carrot);
            TipsManager.disableTipEvent?.Invoke();
        }
    }
}
