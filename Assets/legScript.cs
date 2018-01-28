using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegScript : MonoBehaviour {


        private float jumpSpeed = 1000.0f;
    private Rigidbody rb;
    private bool isGrounded = true;

	// Use this for initialization
	void Start () {
       // rb = transform.parent.GetComponentsInParent<Rigidbody>()[1];
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            //rb.AddForce(Vector3.up * jumpSpeed);
            //isGrounded = false;
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Floor")
        {
            Debug.Log("Collision Floor");
    
        }
    }

}
