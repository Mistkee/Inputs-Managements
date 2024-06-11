using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.UIElements;

public class CurrentBinding : MonoBehaviour
{
    [SerializeField] GameObject imageDisplayed;
    [SerializeField] InputActionReference firstBinding;
    [SerializeField] TMP_Text bindingText;
    InputAction currentBinding;
    bool isUsingController;
    string currentDevice;
    private void Awake()
    {
        
        currentBinding = firstBinding;

       
    }

    private void Update()
    {
        currentDevice = GameObject.Find("Canvas").GetComponent<PlayerInput>().currentControlScheme;
        if (currentDevice == "Keyboard&Mouse")
        {
            isUsingController = false;
            imageDisplayed.SetActive(false);
        }
        else
        {
            isUsingController = true;
            bindingText.enabled = false;
            imageDisplayed.SetActive(true);
        }
    }
    public void InitiateRebind()
    {
        RebindScript.instance.RebindData(currentBinding, gameObject, bindingText);
    }

    public void SetCurrentBinding(InputAction newBinding, Sprite newIcon, TMP_Text newKeyboardIcon)
    {
        currentBinding = newBinding;
        if (newIcon != null)
        {
            imageDisplayed.GetComponent<Image>().sprite = newIcon;
        }
        else
        {
            bindingText = newKeyboardIcon;
        }

    }
}
