using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 offset;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = target.transform.position + offset;
        transform.position = Vector3.Lerp(transform.position, newPos, speed * Time.deltaTime);
    }
}
