//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Inputs/DiaryInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DiaryInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DiaryInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DiaryInputs"",
    ""maps"": [
        {
            ""name"": ""Diary"",
            ""id"": ""9c5a0e16-e519-444e-97eb-c1c3fdcee638"",
            ""actions"": [
                {
                    ""name"": ""Switch Tab Up"",
                    ""type"": ""Button"",
                    ""id"": ""7bf70dcb-df2e-487b-a3aa-b96a573e1d67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch Tab Down"",
                    ""type"": ""Button"",
                    ""id"": ""4181d7ca-6b8f-40ce-bf27-b66859bc6e33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch Pages Right"",
                    ""type"": ""Button"",
                    ""id"": ""a55a3152-c82e-4b09-b69e-de1fc2043957"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch Pages Left"",
                    ""type"": ""Button"",
                    ""id"": ""66139a29-53eb-4681-8ca0-0a9423a764b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e23fb9ec-6b5b-44f2-a95f-869037b1306d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Tab Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a08b1fee-1708-4304-8c63-3339e0fe8dc3"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Tab Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ac60361-0ab2-4ea8-b850-cc7f8e4d6e4c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Tab Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8ef2a54-d497-48a4-bd5f-3fa416e4c9a1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Tab Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b6a99c7-8fe4-48a2-8b77-4ff0e1dc4195"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Pages Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dff804d0-3ce4-49cd-a36e-bbbc418f7fe5"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Pages Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7af09907-5019-4e11-aa21-b33ab76f6d53"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Pages Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0057dfed-29ab-4183-ace4-e6cea4247759"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Pages Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Diary
        m_Diary = asset.FindActionMap("Diary", throwIfNotFound: true);
        m_Diary_SwitchTabUp = m_Diary.FindAction("Switch Tab Up", throwIfNotFound: true);
        m_Diary_SwitchTabDown = m_Diary.FindAction("Switch Tab Down", throwIfNotFound: true);
        m_Diary_SwitchPagesRight = m_Diary.FindAction("Switch Pages Right", throwIfNotFound: true);
        m_Diary_SwitchPagesLeft = m_Diary.FindAction("Switch Pages Left", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Diary
    private readonly InputActionMap m_Diary;
    private List<IDiaryActions> m_DiaryActionsCallbackInterfaces = new List<IDiaryActions>();
    private readonly InputAction m_Diary_SwitchTabUp;
    private readonly InputAction m_Diary_SwitchTabDown;
    private readonly InputAction m_Diary_SwitchPagesRight;
    private readonly InputAction m_Diary_SwitchPagesLeft;
    public struct DiaryActions
    {
        private @DiaryInputs m_Wrapper;
        public DiaryActions(@DiaryInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchTabUp => m_Wrapper.m_Diary_SwitchTabUp;
        public InputAction @SwitchTabDown => m_Wrapper.m_Diary_SwitchTabDown;
        public InputAction @SwitchPagesRight => m_Wrapper.m_Diary_SwitchPagesRight;
        public InputAction @SwitchPagesLeft => m_Wrapper.m_Diary_SwitchPagesLeft;
        public InputActionMap Get() { return m_Wrapper.m_Diary; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DiaryActions set) { return set.Get(); }
        public void AddCallbacks(IDiaryActions instance)
        {
            if (instance == null || m_Wrapper.m_DiaryActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DiaryActionsCallbackInterfaces.Add(instance);
            @SwitchTabUp.started += instance.OnSwitchTabUp;
            @SwitchTabUp.performed += instance.OnSwitchTabUp;
            @SwitchTabUp.canceled += instance.OnSwitchTabUp;
            @SwitchTabDown.started += instance.OnSwitchTabDown;
            @SwitchTabDown.performed += instance.OnSwitchTabDown;
            @SwitchTabDown.canceled += instance.OnSwitchTabDown;
            @SwitchPagesRight.started += instance.OnSwitchPagesRight;
            @SwitchPagesRight.performed += instance.OnSwitchPagesRight;
            @SwitchPagesRight.canceled += instance.OnSwitchPagesRight;
            @SwitchPagesLeft.started += instance.OnSwitchPagesLeft;
            @SwitchPagesLeft.performed += instance.OnSwitchPagesLeft;
            @SwitchPagesLeft.canceled += instance.OnSwitchPagesLeft;
        }

        private void UnregisterCallbacks(IDiaryActions instance)
        {
            @SwitchTabUp.started -= instance.OnSwitchTabUp;
            @SwitchTabUp.performed -= instance.OnSwitchTabUp;
            @SwitchTabUp.canceled -= instance.OnSwitchTabUp;
            @SwitchTabDown.started -= instance.OnSwitchTabDown;
            @SwitchTabDown.performed -= instance.OnSwitchTabDown;
            @SwitchTabDown.canceled -= instance.OnSwitchTabDown;
            @SwitchPagesRight.started -= instance.OnSwitchPagesRight;
            @SwitchPagesRight.performed -= instance.OnSwitchPagesRight;
            @SwitchPagesRight.canceled -= instance.OnSwitchPagesRight;
            @SwitchPagesLeft.started -= instance.OnSwitchPagesLeft;
            @SwitchPagesLeft.performed -= instance.OnSwitchPagesLeft;
            @SwitchPagesLeft.canceled -= instance.OnSwitchPagesLeft;
        }

        public void RemoveCallbacks(IDiaryActions instance)
        {
            if (m_Wrapper.m_DiaryActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDiaryActions instance)
        {
            foreach (var item in m_Wrapper.m_DiaryActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DiaryActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DiaryActions @Diary => new DiaryActions(this);
    public interface IDiaryActions
    {
        void OnSwitchTabUp(InputAction.CallbackContext context);
        void OnSwitchTabDown(InputAction.CallbackContext context);
        void OnSwitchPagesRight(InputAction.CallbackContext context);
        void OnSwitchPagesLeft(InputAction.CallbackContext context);
    }
}
