using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float distance;
    public static bool isTouched = false;
    private NavMeshAgent agent;
    private Transform target;
    private Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        StartCoroutine(Booster());
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        anim.SetBool("isWalk", agent.velocity.magnitude > 0.1f);
        Booster();
        Death();
    }

    void Death()
    {
        float isDistance = Vector3.Distance(transform.position, target.position);
        if (isDistance <= distance)
        {
            isTouched = true;
        }
    }
    IEnumerator Booster()
    {
        while (true)
        {
            yield return new WaitForSeconds(30);
            agent.speed++;
        }
    }
}
