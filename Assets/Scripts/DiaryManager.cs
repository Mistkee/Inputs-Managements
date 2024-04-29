using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class NotesTabScript : MonoBehaviour
{
    PlayerInput inputs;
    [SerializeField]List<GameObject> tabs = new List<GameObject>();

    int currentTab;

    private void Awake()
    {
        inputs = GetComponent<PlayerInput>();

        for (int i = 0; i < tabs.Count; i++)
        {
            tabs[i].SetActive(false);
        }
    }

    private void Start()
    {
        currentTab = 0;
        tabs[0].SetActive(true);
    }

    private void OnEnable()
    {
        inputs.actions["Switch Tab Up"].performed += SwitchTabUp;
        inputs.actions["Switch Tab Down"].performed += SwitchTabDown;
    }

    //Switch to the tab above the current one
    void SwitchTabUp(InputAction.CallbackContext context)
    {
        tabs[currentTab].SetActive(false);
        if (currentTab != 0)
        {
            currentTab--;
            tabs[currentTab].SetActive(true);
        }
        else
        {
            currentTab = tabs.Count - 1;
            tabs[currentTab].SetActive(true);
        }
        CheckCurrentTab();
    }

    //Switch to the tab below the current one
    void SwitchTabDown(InputAction.CallbackContext context)
    {
        tabs[currentTab].SetActive(false);
        if (currentTab < tabs.Count - 1)
        {
            currentTab++;
            tabs[currentTab].SetActive(true);
        }
        else
        {
            currentTab = 0;
            tabs[currentTab].SetActive(true);
        }
        CheckCurrentTab();
    }

    void SwitchRightPage(InputAction.CallbackContext context)
    {
        Debug.Log("switching to right page");
    }

    void SwitchLeftPage(InputAction.CallbackContext context) 
    {
        Debug.Log("switching to left page");
    }

    void CheckCurrentTab()
    {
        if (tabs[currentTab].tag != "Settings")
        {
            inputs.actions["Switch Pages Right"].performed += SwitchRightPage;
            inputs.actions["Switch Pages Left"].performed += SwitchLeftPage;
        }
        else
        {
            inputs.actions["Switch Pages Right"].performed -= SwitchRightPage;
            inputs.actions["Switch Pages Left"].performed -= SwitchLeftPage;
        }
    }

    void OpenSettingsTab()
    {

    }
}
