using UnityEngine;

public interface IPLayerState
{
    void Start(GameObject self);
    void Update(GameObject self);
    void FixedUpdate(GameObject self);
    void OnEnd(GameObject gameObject);
}   