using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	public enum RotationAxes
    {
        MouseXandY=0,
        MouseX=1,
        MouseY=2
    }
    public RotationAxes axes = RotationAxes.MouseXandY;
    public float senseHor = 9.0f;
    public float senseVer = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    float _rotationX;
    // using enum for setting values by name instead of remebering it bu numbers
    // we want to limit the vertical rotation (whixh happen around the x axis) 
    //so we create a var and limit it with math.clamp
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();//get the comp. on the object
        if (body != null)                          //check if exist 
            body.freezeRotation = true;//let mouse handle rotation without interference from the rigidbody
    }


    void Update () {
        
        if (axes==RotationAxes.MouseX)
        {
            transform.Rotate(0,Input.GetAxis("Mouse X")*senseHor,0);
        }else if (axes==RotationAxes.MouseY)
        {
           

            _rotationX -= Input.GetAxis("Mouse Y") * senseVer;

            _rotationX = Mathf.Clamp(_rotationX,minimumVert,maximumVert);

            float _rotationY = transform.localEulerAngles.y;

            //Debug.Log(transform.localEulerAngles.y);-->zero

            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);

            //The reason why we need to create a new Vector3 
            //instead of changing values in the existing vector in the transform 
            //is because those values are read - only for transforms.

        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * senseVer;

            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * senseHor;

            float _rotationY = transform.localEulerAngles.y + delta;


            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);

        }
		
	}
}
