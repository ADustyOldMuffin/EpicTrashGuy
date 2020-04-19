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
        },
        {
            ""name"": ""Attack"",
            ""id"": ""07be1f1c-8ef2-4d72-a520-d8c2e3b7da24"",
            ""actions"": [
                {
                    ""name"": ""MeleeAttack"",
                    ""type"": ""Button"",
                    ""id"": ""406b7126-a825-4162-8e8a-87cf579093ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RangedAttack"",
                    ""type"": ""Button"",
                    ""id"": ""ee911189-d4ca-4518-91e2-813c2b8da2af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""411e9b19-3402-4b6d-9997-d1a5f50e94e6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23381f0c-be7f-4bfa-bb88-f58411df4aef"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RangedAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Clean"",
            ""id"": ""e8df4448-1df5-422c-a03e-32d980574f86"",
            ""actions"": [
                {
                    ""name"": ""Clean"",
                    ""type"": ""Button"",
                    ""id"": ""841a4206-ed47-459a-979b-9e60e5b66edf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d85457cd-20d5-4cfb-9fa2-857fae406fa9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clean"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_MeleeAttack = m_Attack.FindAction("MeleeAttack", throwIfNotFound: true);
        m_Attack_RangedAttack = m_Attack.FindAction("RangedAttack", throwIfNotFound: true);
        // Clean
        m_Clean = asset.FindActionMap("Clean", throwIfNotFound: true);
        m_Clean_Clean = m_Clean.FindAction("Clean", throwIfNotFound: true);
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

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_MeleeAttack;
    private readonly InputAction m_Attack_RangedAttack;
    public struct AttackActions
    {
        private @InputMaster m_Wrapper;
        public AttackActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MeleeAttack => m_Wrapper.m_Attack_MeleeAttack;
        public InputAction @RangedAttack => m_Wrapper.m_Attack_RangedAttack;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @MeleeAttack.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnMeleeAttack;
                @RangedAttack.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnRangedAttack;
                @RangedAttack.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnRangedAttack;
                @RangedAttack.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnRangedAttack;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MeleeAttack.started += instance.OnMeleeAttack;
                @MeleeAttack.performed += instance.OnMeleeAttack;
                @MeleeAttack.canceled += instance.OnMeleeAttack;
                @RangedAttack.started += instance.OnRangedAttack;
                @RangedAttack.performed += instance.OnRangedAttack;
                @RangedAttack.canceled += instance.OnRangedAttack;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);

    // Clean
    private readonly InputActionMap m_Clean;
    private ICleanActions m_CleanActionsCallbackInterface;
    private readonly InputAction m_Clean_Clean;
    public struct CleanActions
    {
        private @InputMaster m_Wrapper;
        public CleanActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Clean => m_Wrapper.m_Clean_Clean;
        public InputActionMap Get() { return m_Wrapper.m_Clean; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CleanActions set) { return set.Get(); }
        public void SetCallbacks(ICleanActions instance)
        {
            if (m_Wrapper.m_CleanActionsCallbackInterface != null)
            {
                @Clean.started -= m_Wrapper.m_CleanActionsCallbackInterface.OnClean;
                @Clean.performed -= m_Wrapper.m_CleanActionsCallbackInterface.OnClean;
                @Clean.canceled -= m_Wrapper.m_CleanActionsCallbackInterface.OnClean;
            }
            m_Wrapper.m_CleanActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Clean.started += instance.OnClean;
                @Clean.performed += instance.OnClean;
                @Clean.canceled += instance.OnClean;
            }
        }
    }
    public CleanActions @Clean => new CleanActions(this);
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
    public interface IAttackActions
    {
        void OnMeleeAttack(InputAction.CallbackContext context);
        void OnRangedAttack(InputAction.CallbackContext context);
    }
    public interface ICleanActions
    {
        void OnClean(InputAction.CallbackContext context);
    }
}
