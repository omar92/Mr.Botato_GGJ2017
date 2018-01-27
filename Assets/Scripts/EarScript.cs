using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarScript : MonoBehaviour , IPart {
    public void Activate()
    {
        this.GetComponent<AudioListener>().enabled = true;
    }

    public void Diactiviate()
    {
        this.GetComponent<AudioListener>().enabled = false;
    }

    public void DoAction()
    {
        
    }

    public void Toggle()
    {
        this.GetComponent<AudioListener>().enabled = !this.GetComponent<AudioListener>().enabled;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
