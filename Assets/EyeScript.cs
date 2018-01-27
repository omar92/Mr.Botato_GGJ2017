using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeScript : MonoBehaviour, IPart {

    public Camera Eyecamera;

    void Start ()
    {
        Eyecamera = GetComponentInChildren<Camera>();	
	}

    public void Activate()
    {
        Eyecamera.enabled = true;

    }

    public void Diactiviate()
    {

        Eyecamera.enabled = false;
    }

    public void DoAction()
    {
    }

 
	
	void Update () {
		
	}

    public void Toggle()
    {
        Eyecamera.enabled = !Eyecamera.enabled;
    }
}
