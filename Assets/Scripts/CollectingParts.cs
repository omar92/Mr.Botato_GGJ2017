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

    public float senseHor = 9.0f;
    public float senseVer = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    float _rotationX;
    public Transform[] PartsPositionsInBody;

    int legsNum = 0;
    int armsNum = 0;
    int eyesNum = 0;
    int earsNum = 0;

    private bool PlayerFoundAPart = false;
    private GameObject foundPart;
    private Rigidbody rb;

    MouseLook lookl;
    MouseLook lookr;
    PlayerController protation;
    Camera camera;
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
                            foundPart.transform.parent = PartsPositionsInBody[0].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[0].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[0].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[0].localScale;
                            foundPart.GetComponent<Collider>().isTrigger = false;
                            foundPart.GetComponent<LegScript>().enabled = true;

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
                            foundPart.transform.parent = PartsPositionsInBody[1].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[1].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[1].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[1].localScale;
                            foundPart.GetComponent<Collider>().isTrigger = false;
                            foundPart.GetComponent<LegScript>().enabled = true;

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
                            foundPart.transform.parent = PartsPositionsInBody[2].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[2].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[2].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[2].localScale;

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
                            foundPart.transform.parent = PartsPositionsInBody[3].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[3].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[3].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[3].localScale;
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
                            foundPart.transform.parent = PartsPositionsInBody[4].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[4].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[4].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[4].localScale;
                            lookl = GetComponentInChildren<MouseLook>();
                            //foundPart.GetComponentInChildren<Camera>().rect.position = new Vector2(0, 0);
                            // foundPart.GetComponentInChildren<Camera>().rect.position = new Vector2(0, 0);
                            //if (eyesNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEyePlayerState(), this.gameObject);

                                eyesNum++;
                            if (eyesNum==2)
                            {
                                lookl.enabled = false;
                                
                            }
                            else
                            {
                                if (lookl.enabled )
                                {

                                }
                                else
                                {
                                    lookl.enabled = true;
                                }
                                //camera = GetComponent<Camera>();
                                //_rotationX -= Input.GetAxis("Mouse Y") * senseVer;

                                //_rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

                                //float delta = Input.GetAxis("Mouse X") * senseHor;

                                //float _rotationY = transform.localEulerAngles.y + delta;


                                //transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);

                            }
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
                            foundPart.transform.parent = PartsPositionsInBody[5].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[5].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[5].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[5].localScale;

                            lookr = GetComponentInChildren<MouseLook>();
                            //if (eyesNum == 0)
                            //{
                            //    PlayerController.SwitchState(new OneEyePlayerState(), this.gameObject);
                            eyesNum++;
                            if (eyesNum == 2)
                            {
                                lookr.enabled = false;
                            }
                            else
                            {
                                if (lookr.enabled )
                                {

                                }
                                else {
                                    lookr.enabled = true;
                                }

                               // camera = GetComponent<Camera>();
                                //_rotationX -= Input.GetAxis("Mouse Y") * senseVer;

                                //_rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

                                //float delta = Input.GetAxis("Mouse X") * senseHor;

                                //float _rotationY = transform.localEulerAngles.y + delta;


                                //transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
                            }
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
                            foundPart.transform.parent = PartsPositionsInBody[6].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[6].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[6].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[6].localScale;
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
                            foundPart.transform.parent = PartsPositionsInBody[7].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[7].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[7].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[7].localScale;
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
                            foundPart.transform.parent = PartsPositionsInBody[8].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[8].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[8].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[8].localScale;

                            // PlayerController.SwitchState(new NosePlayerState(), this.gameObject);

                            break;
                        }
                    case "mouth":
                        {
                            foundPart.transform.parent = PartsPositionsInBody[9].parent.transform;
                            foundPart.transform.localPosition = PartsPositionsInBody[9].localPosition;
                            foundPart.transform.localRotation = PartsPositionsInBody[9].localRotation;
                            foundPart.transform.localScale = PartsPositionsInBody[9].localScale;

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
