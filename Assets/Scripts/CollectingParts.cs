using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct Part
{
    public string name;
    public Transform transfom;
}


public class CollectingParts : MonoBehaviour
{ 
    public Transform[] PartsPositionsInBody;

    private bool PlayerFoundAPart = false;
    private GameObject foundPart;
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
	    if(PlayerFoundAPart)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Debug.Log("C pressed");
                foundPart.transform.parent   = PartsPositionsInBody[0].transform;
                foundPart.transform.position = PartsPositionsInBody[0].position;
                foundPart.transform.rotation = PartsPositionsInBody[0].rotation;
                foundPart.GetComponent<Collider>().isTrigger = false;
                PlayerController.SwitchState(new OneLegPlayerState(), this.gameObject);

                foundPart.GetComponent<legScript>().enabled = true;
                //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.1f);

                // StartCoroutine(ResetPlayerRotation());

                //StartCoroutine(MovePart(foundPart.gameObject, PartsPositionsInBody[0].position));
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "LeftLeg":
            {
                    Debug.Log("LEft Arm");
                    PlayerFoundAPart = true;
                    foundPart = other.gameObject;
                    break;
                }
            case "RightArm":
            {
                    Debug.Log("====> Left Arm");
                    other.transform.parent = PartsPositionsInBody[0].transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    ////StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "LeftArm":
            {
                    Debug.Log("====> Right Leg");
                    other.transform.parent = PartsPositionsInBody[0].transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    // //StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "RightLeg":
            {
                    Debug.Log("====> Right Leg");
                    other.transform.parent = PartsPositionsInBody[0].transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    ////StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "LeftEye":
            {
                    Debug.Log("====> Left Eye");
                    other.transform.parent = PartsPositionsInBody[0].transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    ////StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "RightEye":
            {
                    Debug.Log("====>Right Eye");
                    other.transform.parent = PartsPositionsInBody[0].transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    // //StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "LeftEar":
            {
                    Debug.Log("====> Left Ear");
                    other.transform.parent = transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    ////StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "RightEar":
            {
                    Debug.Log("====> Left Arm");
                    other.transform.parent = transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    // //StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
            case "Nose":
            {
                    Debug.Log("====> Nose");
                    other.transform.parent = transform;
                    other.transform.position = PartsPositionsInBody[0].position;
                    other.transform.rotation = PartsPositionsInBody[0].rotation;
                    //other.transform.position = PartsPositionsInBody[0].position;
                    ////StartCoroutine(MovePart(other.gameObject, PartsPositionsInBody[0].position));

                    break;
            }
        }
    }

    IEnumerator MovePart(GameObject part, Vector3 finalPosition)
    {
        float elapsedTime = 0;
        float moveTime = 0.5f;

        while(elapsedTime < moveTime)
        {
            part.transform.position = Vector3.Lerp(part.transform.position, finalPosition, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }


    IEnumerator ResetPlayerRotation()
    {
        float elapsedTime = 0.0f;
        float resetTime = 2.0f;
        while (elapsedTime < resetTime)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, elapsedTime / resetTime);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }


}
