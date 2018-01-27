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

    int legsNum = 0;
    int armsNum = 0;
    int eyesNum = 0;
    int earsNum = 0;

    private bool PlayerFoundAPart = false;
    private GameObject foundPart;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (PlayerFoundAPart)
        {
            //if (Input.GetKeyDown(KeyCode.C))
            {
                switch (foundPart.tag)
                {
                    case "LeftLeg":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[0].transform;
                            foundPart.transform.position = PartsPositionsInBody[0].position;
                            foundPart.transform.rotation = PartsPositionsInBody[0].rotation;
                            foundPart.GetComponent<Collider>().isTrigger = false;
                            foundPart.GetComponent<legScript>().enabled = true;

                            if (legsNum == 0)
                            {
                                PlayerController.SwitchState(new OneLegPlayerState(), this.gameObject);
                                legsNum++;
                            }
                            else if (legsNum == 1)
                            {
                                PlayerController.SwitchState(new TwoLegPlayerState(), this.gameObject);
                                legsNum++;
                            }
                            break;
                        }
                    case "RightLeg":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[1].transform;
                            foundPart.transform.position = PartsPositionsInBody[1].position;
                            foundPart.transform.rotation = PartsPositionsInBody[1].rotation;
                            foundPart.GetComponent<Collider>().isTrigger = false;
                            foundPart.GetComponent<legScript>().enabled = true;

                            if (legsNum == 0)
                            {
                                PlayerController.SwitchState(new OneLegPlayerState(), this.gameObject);
                                legsNum++;
                            }
                            else if (legsNum == 1)
                            {
                                PlayerController.SwitchState(new TwoLegPlayerState(), this.gameObject);
                                legsNum++;
                            }
                            break;
                        }
                    case "LeftArm":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[2].transform;
                            foundPart.transform.position = PartsPositionsInBody[2].position;
                            foundPart.transform.rotation = PartsPositionsInBody[2].rotation;
                            //if (armsNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneArmPlayerState(), this.gameObject);
                            //    armsNum++;
                            //}
                            //else if (armsNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoArmPlayerState(), this.gameObject);
                            //    armsNum++;
                            //}
                            break;
                        }
                    case "RightArm":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[3].transform;
                            foundPart.transform.position = PartsPositionsInBody[3].position;
                            foundPart.transform.rotation = PartsPositionsInBody[3].rotation;
                            //if (armsNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneArmPlayerState(), this.gameObject);
                            //    armsNum++;
                            //}
                            //else if (armsNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoArmPlayerState(), this.gameObject);
                            //    armsNum++;
                            //}
                            break;
                        }
                    case "LeftEye":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[4].transform;
                            foundPart.transform.position = PartsPositionsInBody[4].position;
                            foundPart.transform.rotation = PartsPositionsInBody[4].rotation;
                            //foundPart.GetComponentInChildren<Camera>().rect.position = new Vector2(0, 0);
                           // foundPart.GetComponentInChildren<Camera>().rect.position = new Vector2(0, 0);
                            //if (eyesNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEyePlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            //else if (eyesNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoEyePlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            break;
                        }
                    case "RightEye":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[5].transform;
                            foundPart.transform.position = PartsPositionsInBody[5].position;
                            foundPart.transform.rotation = PartsPositionsInBody[5].rotation;

                            //if (eyesNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEyePlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            //else if (eyesNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoEyePlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            break;
                        }
                    case "LeftEar":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[6].transform;
                            foundPart.transform.position = PartsPositionsInBody[6].position;
                            foundPart.transform.rotation = PartsPositionsInBody[6].rotation;

                            //if (earsNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEarPlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            //else if (earsNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoEarPlayerState(), this.gameObject);
                            //    earsNum++;
                            //}
                            break;
                        }
                    case "RightEar":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[7].transform;
                            foundPart.transform.position = PartsPositionsInBody[7].position;
                            foundPart.transform.rotation = PartsPositionsInBody[7].rotation;

                            //if (earsNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEarPlayerState(), this.gameObject);
                            //    eyesNum++;
                            //}
                            //else if (earsNum == 1)
                            //{
                            //    PlayerController.SwitchState(new TwoEarPlayerState(), this.gameObject);
                            //    earsNum++;
                            //}
                            break;
                        }

                    case "Nose":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[8].transform;
                            foundPart.transform.position = PartsPositionsInBody[8].position;
                            foundPart.transform.rotation = PartsPositionsInBody[8].rotation;

                           // PlayerController.SwitchState(new NosePlayerState(), this.gameObject);

                            break;
                        }
                    case "mouth":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[9].transform;
                            foundPart.transform.position = PartsPositionsInBody[9].position;
                            foundPart.transform.rotation = PartsPositionsInBody[9].rotation;

                           // PlayerController.SwitchState(new MouthPlayerState(), this.gameObject);

                            break;
                        }

                      
                }
                var rb = foundPart.GetComponentInChildren<Rigidbody>();
                if(rb != null)
                {
                    rb.isKinematic = true;
                }
                PlayerFoundAPart = false;
                foundPart = null;
                //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.1f);
                // StartCoroutine(ResetPlayerRotation());
                //StartCoroutine(MovePart(foundPart.gameObject, PartsPositionsInBody[0].position));
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "LeftLeg":
            case "RightArm":
            case "LeftArm":
            case "RightLeg":
            case "LeftEye":
            case "RightEye":
            case "LeftEar":
            case "RightEar":
            case "Nose":
            case "Mouth":
                {
                    Debug.Log("found "+ other.tag);
                    PlayerFoundAPart = true;
                    foundPart = other.gameObject;
                    break;
                }
        }
    }

    IEnumerator MovePart(GameObject part, Vector3 finalPosition)
    {
        float elapsedTime = 0;
        float moveTime = 0.5f;

        while (elapsedTime < moveTime)
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
