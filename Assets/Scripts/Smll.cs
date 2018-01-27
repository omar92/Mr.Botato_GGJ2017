using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smll : MonoBehaviour,IPart {

    public Smll nose;
    public Text smelltaxt;

    void Start()
    {
        nose = GetComponent<Smll>();
        smelltaxt = gameObject.GetComponentInChildren<Text>();// GameObject.Find("SmellText").GetComponent<Text>();
        smelltaxt.enabled = false;
    }
    public void Activate()
    {
        nose.enabled = true;
    }

    public void Diactiviate()
    {
        nose.enabled = false;
    }

    public void DoAction()
    {
        throw new NotImplementedException();
    }

    public void Toggle()
    {
        nose.enabled = !nose.enabled;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poop")
        {
            Debug.Log("okkkkkkkkkkk");
            StartCoroutine(showMessage(" i think that is a poop smell ", 3));
            
        }
    }
    // Use this for initialization
    IEnumerator showMessage(string message, float delay)
    {
        smelltaxt.text = message;
       
        smelltaxt.enabled = true;
        yield return new WaitForSeconds(delay);
        smelltaxt.enabled = false;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
