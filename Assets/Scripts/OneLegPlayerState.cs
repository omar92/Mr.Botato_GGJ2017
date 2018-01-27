using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneLegPlayerState :  IPLayerState {

    private float jumpSpeed = 1000.0f;
    private Rigidbody rb;
    private bool isGrounded = true;

    public void FixedUpdate(GameObject self)
    {
    }

    public void OnEnd(GameObject gameObject)
    {
    }

    public void Start(GameObject player)
    {
        rb = player.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
      //  player.GetComponent<BoxCollider>().enabled = true;
      //  player.GetComponent<SphereCollider>().enabled = false;
        player.transform.rotation=(Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        player.transform.position += Vector3.up * 2;
    }

    public void Update(GameObject player)
    {
        //if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        //{ 
        //    rb.AddForce(Vector3.up * jumpSpeed);
        //    isGrounded = false;
        //}
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Collision");
    //    if(collision.collider.tag == "Floor")
    //    {
    //        Debug.Log("Collision Floor");
    //        isGrounded = true;
    //    }
    //}

    IEnumerator ResetPlayer(GameObject player)
    {
        yield return new WaitForSeconds(1.0f);
        player.transform.eulerAngles = Vector3.zero;
        player.transform.position += new Vector3(0, 200, 0);
    }



}
