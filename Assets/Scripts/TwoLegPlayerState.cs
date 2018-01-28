using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoLegPlayerState :  IPLayerState {


    public float speed = 20.0f;
    public float maxVelocity = 20.0f;

    private float jumpSpeed = 1.0f;
    private Rigidbody rb;

    private LegScript legScript = null;


    public void FixedUpdate(GameObject self)

    {
         
        //var v = rb.velocity;
        //v.x = 0;
        //v.z = 0;
        //if (v.y > 5)
        //{
        //    v.y = 5;
        //}
        //rb.velocity = v;
        if (Math.Abs(rb.velocity.x) > maxVelocity)
        {
            rb.velocity = new Vector3(maxVelocity, 0, rb.velocity.z);
        }
        if (Math.Abs(rb.velocity.z) > maxVelocity)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, maxVelocity);
        }

    }

    public void OnEnd(GameObject gameObject)
    {

    }

    public void Start(GameObject player)
    {

        rb = player.GetComponent<Rigidbody>();
        legScript = player.GetComponentInChildren<LegScript>();
        rb.velocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        //  player.GetComponent<BoxCollider>().enabled = true;
        //  player.GetComponent<SphereCollider>().enabled = false;
        player.transform.rotation = (Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        player.transform.position += Vector3.up * 2;



    }

    public void Update(GameObject player)
    {
        float MovmentHorizontal = Input.GetAxis("Horizontal");
        float MovmentVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MovmentHorizontal, 0, MovmentVertical);
        rb.AddForce(movement * speed);






        //if ( legScript.IsGrounded)
        //{
        //    rb.AddForce(player.transform.up * jumpSpeed,ForceMode.Impulse);
        //    //legScript.IsGrounded = false;
        //}



    }

    IEnumerator ResetPlayer(GameObject player)
    {
        yield return new WaitForSeconds(1.0f);
        player.transform.eulerAngles = Vector3.zero;
        player.transform.position += new Vector3(0, 200, 0);
    }



}
