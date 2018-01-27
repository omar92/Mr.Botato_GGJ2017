using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    IPart PreviousActivePart;
    IPart CurrentActivePart;
   
    public void ActivatePart(GameObject part)
    {
        if(CurrentActivePart != null)
        {
            CurrentActivePart.Diactiviate();
        }
        CurrentActivePart = part.GetComponent<IPart>();
        CurrentActivePart.Activate();
    }


    public void TogglePart(GameObject part)
    {
        if (CurrentActivePart != null)
        {
            if(CurrentActivePart != part.GetComponent<IPart>())
            {
                CurrentActivePart.Diactiviate();
            } 
        }
        CurrentActivePart = part.GetComponent<IPart>();
        CurrentActivePart.Toggle();
    }



    void Start ()
    {
	    	
	}
	
	void Update ()
    {
		
	}
}
