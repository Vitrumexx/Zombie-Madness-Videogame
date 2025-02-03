using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public static float speed;
    public Rigidbody rg;
    public Animator anim;

    private void Start()
    {
        speed = 5.0f;
        rg = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if(moveInput.magnitude > 0.1f)
        {
            Quaternion rotation = Quaternion.LookRotation(moveInput);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed);
        }
        anim.SetBool("isWalk", moveInput.magnitude > 0.1f);
        rg.velocity = moveInput * speed;
    }
}
