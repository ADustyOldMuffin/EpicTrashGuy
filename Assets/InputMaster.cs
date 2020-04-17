// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""dc01e508-0453-4c72-98d2-5e9c6a271b83"",
            ""actions"": [
                {
                    ""name"": ""UpAndDown"",
                    ""type"": ""Button"",
                    ""id"": ""41e3d632-e4ed-468f-ac18-4a36cfebc514"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sideways"",
                    ""type"": ""Button"",
                    ""id"": ""87ffe83a-9392-41a9-aa61-e5e334555b94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSKeys"",
                    ""id"": ""811a3988-ddec-4374-a2f1-56db9f0526f9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpAndDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""70809bed-7a07-424d-8562-bd69f873edb5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpAndDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3111c3d5-c4e7-45c5-b5db-1b7c13e9166b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpAndDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ADKeys"",
                    ""id"": ""fdc6db02-da43-467b-bf4d-cdb9a67dcc03"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6339b6a8-9774-4f98-bbea-5f2738ebdede"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e8ee9719-edb4-4c2d-83c1-c6ac50d61981"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sideways"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_UpAndDown = m_Movement.FindAction("UpAndDown", throwIfNotFound: true);
        m_Movement_Sideways = m_Movement.FindAction("Sideways", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_UpAndDown;
    private readonly InputAction m_Movement_Sideways;
    public struct MovementActions
    {
        private @InputMaster m_Wrapper;
        public MovementActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @UpAndDown => m_Wrapper.m_Movement_UpAndDown;
        public InputAction @Sideways => m_Wrapper.m_Movement_Sideways;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @UpAndDown.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnUpAndDown;
                @UpAndDown.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnUpAndDown;
                @UpAndDown.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnUpAndDown;
                @Sideways.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSideways;
                @Sideways.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSideways;
                @Sideways.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSideways;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UpAndDown.started += instance.OnUpAndDown;
                @UpAndDown.performed += instance.OnUpAndDown;
                @UpAndDown.canceled += instance.OnUpAndDown;
                @Sideways.started += instance.OnSideways;
                @Sideways.performed += instance.OnSideways;
                @Sideways.canceled += instance.OnSideways;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnUpAndDown(InputAction.CallbackContext context);
        void OnSideways(InputAction.CallbackContext context);
    }
}
