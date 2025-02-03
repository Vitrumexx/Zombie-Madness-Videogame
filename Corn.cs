using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Corn : MonoBehaviour
{
    public GameObject corn;
    private Transform player;
    public static int Corns;
    void Start()
    {
        Corns = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float CornDistance = Vector3.Distance(transform.position, player.position);
        if (CornDistance <= 2 && Input.GetKeyDown(KeyCode.E))
        {
            Corns++;
            Destroy(corn);
            TipsManager.disableTipEvent?.Invoke();
        }
    }
}