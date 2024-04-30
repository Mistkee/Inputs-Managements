using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CurrentBinding : MonoBehaviour
{
    [SerializeField] InputActionReference firstBinding;
    InputAction currentBinding;
    PlayerInput inputs;
    private void Awake()
    {
        inputs = GameObject.Find("Canvas").GetComponent<PlayerInput>();
        currentBinding = firstBinding;
    }

    public void InitiateRebind()
    {
        RebindScript.instance.RebindData(currentBinding, gameObject);
    }

    public void SetCurrentBinding(InputAction newBinding)
    {
        currentBinding = newBinding;
    }
}
