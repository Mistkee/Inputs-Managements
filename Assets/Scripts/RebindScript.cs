using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RebindScript : MonoBehaviour
{
    [SerializeField] GameObject waitingForInput;
    InputActionRebindingExtensions.RebindingOperation rebinding;
    GameObject gameObjectUsed;
    InputAction rebindedInput;
    
    public static RebindScript instance;
    private void Awake()
    {
        waitingForInput.SetActive(false);
        if (instance == null)
        {
            instance = this;
        }
    }

    public void RebindData(InputAction inputToRebind, GameObject gameObjectButton)
    {
        gameObjectUsed = gameObjectButton;
        Rebinding(inputToRebind);
    }
    public void Rebinding(InputAction inputToRebind)
    {
        waitingForInput.SetActive(true);
        inputToRebind.Disable();
        rebinding = inputToRebind.PerformInteractiveRebinding().OnComplete(operation => RebindCompleted());

        rebinding.Start();
        inputToRebind.Enable();
        rebindedInput = inputToRebind;
    }

    void RebindCompleted()
    {
        rebinding.Dispose();
        gameObjectUsed.GetComponent<CurrentBinding>().SetCurrentBinding(rebindedInput);
        waitingForInput.SetActive(false);
    }
}
