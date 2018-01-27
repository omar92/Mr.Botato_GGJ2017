using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private static IPLayerState currentPLayerState = null;

    // Use this for initialization
    void Start()
    {
        SwitchState(new RollingPLayerState(), this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPLayerState != null)
        {
            currentPLayerState.Update(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        if (currentPLayerState != null)
        {
            currentPLayerState.FixedUpdate(this.gameObject);
        }
    }

    public static void SwitchState(IPLayerState newState, GameObject trget)
    {
        if(currentPLayerState != null)
        {
            currentPLayerState.OnEnd(trget);
        }
        currentPLayerState = newState;
        currentPLayerState.Start(trget);
    }
}
