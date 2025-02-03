using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Speed_Bonus : MonoBehaviour
{
    public GameObject boots;
    private Transform player;
    private float cooldown;
    void Start()
    {

        cooldown = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float BootsDistance = Vector3.Distance(transform.position, player.position);
        if (BootsDistance <= 3 && Input.GetKeyDown(KeyCode.E))
        {
            Walk.speed = Walk.speed + 1;
            StartCoroutine(Cooldown());
            Destroy(boots);
            TipsManager.disableTipEvent?.Invoke();
        }
    }

    void Timer()
    {
        cooldown++;
    }

    IEnumerator Cooldown()
    {
            while (cooldown < 5)
            {
                yield return new WaitForSeconds(1);
                Timer();
            }
        Walk.speed = Walk.speed - 1;
        cooldown = 0;
        StopCoroutine(Cooldown());
    }
}
