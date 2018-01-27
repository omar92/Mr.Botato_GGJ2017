using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPLayerState : MonoBehaviour, IPLayerState
{

    public float speed = 10.0f;
    public float maxVelocity = 5.0f;

    BoxCollider playerBoxCollider;
    SphereCollider playerSphereCollider;
    Rigidbody rb;

    public void Start(GameObject player)
    {
        rb = player.GetComponent<Rigidbody>();
        playerBoxCollider = player.GetComponent<BoxCollider>();
        playerSphereCollider = player.GetComponent<SphereCollider>();
        playerSphereCollider.enabled = true;
        playerBoxCollider.enabled = false;
    }

    public void Update (GameObject player)
    {

	}

    public  void FixedUpdate(GameObject player)
    {
        float MovmentHorizontal = Input.GetAxis("Horizontal");
        float MovmentVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MovmentHorizontal, 0, MovmentVertical);

        rb.AddForce(movement * speed);

        if(rb.velocity.x > maxVelocity)
        {
            rb.velocity = new Vector3(maxVelocity, 0, rb.velocity.z);        
        } 
        else if(rb.velocity.z > maxVelocity)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, maxVelocity);
        }
        else if (rb.velocity.x < -maxVelocity)
        {
            rb.velocity = new Vector3(-maxVelocity, 0, rb.velocity.z);
        }
        else if (rb.velocity.z < -maxVelocity)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, -maxVelocity);
        }

        Debug.Log(rb.velocity);

    }

    public void OnEnd(GameObject player)
    {

    }


}
