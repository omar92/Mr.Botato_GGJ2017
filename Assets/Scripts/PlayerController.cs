using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static IPLayerState currentPLayerState = null;

    public static IPLayerState CurrentPLayerState
    {
        get
        {
            return currentPLayerState;
        }
    }

    // Use this for initialization
    void Start()
    {
        SwitchState(new RollingPLayerState(), this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentPLayerState != null)
        {
            CurrentPLayerState.Update(this.gameObject);
        }
    }
    private void FixedUpdate()
    {
        if (CurrentPLayerState != null)
        {
            CurrentPLayerState.FixedUpdate(this.gameObject);
        }
    }

    public static void SwitchState(IPLayerState newState, GameObject trget)
    {
        if(CurrentPLayerState != null)
        {
            CurrentPLayerState.OnEnd(trget);
        }
        currentPLayerState = newState;
        CurrentPLayerState.Start(trget);
    }
}
