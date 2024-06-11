using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Samples.RebindUI;

public class RebindScript : MonoBehaviour
{
    [SerializeField] GameObject waitingForInput;
    InputActionRebindingExtensions.RebindingOperation rebinding;
    GameObject gameObjectUsed;
    InputAction rebindedInput;
    TMP_Text bindingText;
    Sprite newIcon;

    
    public static RebindScript instance;
    private void Awake()
    {
        waitingForInput.SetActive(false);
        if (instance == null)
        {
            instance = this;
        }
    }

    public void RebindData(InputAction inputToRebind, GameObject gameObjectButton, TMP_Text oldText)
    {
        bindingText = oldText;
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
        Debug.Log(inputToRebind.GetBindingDisplayString());
        newIcon = RebindUIScript.instance.UpdateIcons(inputToRebind.GetBindingDisplayString());
    }

    void RebindCompleted()
    {
        int bindingIndex = rebindedInput.GetBindingIndexForControl(rebindedInput.controls[0]);

        bindingText.text = InputControlPath.ToHumanReadableString(rebindedInput.bindings[bindingIndex].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice) ;
        rebinding.Dispose();
        gameObjectUsed.GetComponent<CurrentBinding>().SetCurrentBinding(rebindedInput, newIcon, bindingText);
        waitingForInput.SetActive(false);
    }
}
