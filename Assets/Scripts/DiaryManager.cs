using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class NotesTabScript : MonoBehaviour
{
    PlayerInput inputs;
    [SerializeField]List<GameObject> tabs = new List<GameObject>();
    public List<GameObject> pagesOnTabs = new List<GameObject>();
    int currentTab, currentPage;

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
        CheckCurrentTab();
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
        pagesOnTabs[currentPage].SetActive(false);
        if (currentPage < pagesOnTabs.Count - 1)
        {
            currentPage++;
            pagesOnTabs[currentPage].SetActive(true);
        }
        else
        {
            currentPage = 0;
            pagesOnTabs[currentPage].SetActive(true);
        }
    }

    void SwitchLeftPage(InputAction.CallbackContext context) 
    {
        pagesOnTabs[currentPage].SetActive(false);
        if (currentPage != 0)
        {
            currentPage--;
            pagesOnTabs[currentPage].SetActive(true);
        }
        else
        {
            currentPage = pagesOnTabs.Count - 1;
            pagesOnTabs[currentPage].SetActive(true);
        }
    }

    void CheckCurrentTab()
    {
        currentPage = 0;
        if (tabs[currentTab].tag != "Settings")
        {
            pagesOnTabs.Clear();
            for (int i = 0; i< tabs[currentTab].transform.childCount; i++)
            {
                pagesOnTabs.Add(tabs[currentTab].transform.GetChild(i).gameObject);
                pagesOnTabs[i].SetActive(false);
            }
            pagesOnTabs[currentPage].SetActive(true);
            inputs.actions["Switch Pages Right"].performed += SwitchRightPage;
            inputs.actions["Switch Pages Left"].performed += SwitchLeftPage;
        }
        else
        {
            pagesOnTabs.Clear();
            inputs.actions["Switch Pages Right"].performed -= SwitchRightPage;
            inputs.actions["Switch Pages Left"].performed -= SwitchLeftPage;
        }
    }

    void OpenSettingsTab()
    {

    }
}
