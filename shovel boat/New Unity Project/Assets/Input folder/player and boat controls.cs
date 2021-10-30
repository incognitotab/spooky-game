// GENERATED AUTOMATICALLY FROM 'Assets/Input folder/player and boat controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Playerandboatcontrols : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playerandboatcontrols()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""player and boat controls"",
    ""maps"": [
        {
            ""name"": ""Controller and keyboard"",
            ""id"": ""36f37ade-9a50-47af-afc2-ef6fc8d29692"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""122a1649-d364-44e2-9ca7-7855d067fb65"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look action"",
                    ""type"": ""Value"",
                    ""id"": ""13ff062f-d358-4f53-b146-328134a3eab0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""attack"",
                    ""type"": ""Button"",
                    ""id"": ""957aa41e-3114-4a57-b6b0-8414cab6a8ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look action Cancelled cont"",
                    ""type"": ""Button"",
                    ""id"": ""a9ca49d1-5c69-4f43-80cd-e87707e7407e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look action Start Cont"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95fc8bbf-a066-4ea5-9781-a10b69d96cb3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ab3c643b-3a3e-44c1-a6bb-36804dccfa65"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7c7f507f-60e3-4fac-8b90-17ba40c6a770"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ece4b23-57e6-4613-a09c-e5822e588bb3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e11609d-575e-4f16-bb0e-18fd34b9bade"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a18e3cc1-24b5-4958-a645-ccba14beb91d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8436774c-9ad9-4a97-ab8e-286b67c8a66d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""cont control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fcf220b-10c8-48d0-8cc8-e4fa7a7995b5"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""Look action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae02300e-8bbc-42f6-a207-f0097659699c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""099ec070-07d0-4e09-bf5e-acbcf04518ab"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""cont control scheme"",
                    ""action"": ""attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bdeb9a4-79ee-458d-993b-56aec511fa19"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""cont control scheme"",
                    ""action"": ""Look action Cancelled cont"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f51bd44-191f-4d93-9c8b-6dbb92510dbe"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""cont control scheme"",
                    ""action"": ""Look action Start Cont"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controls"",
            ""bindingGroup"": ""Controls"",
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
        },
        {
            ""name"": ""cont control scheme"",
            ""bindingGroup"": ""cont control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Controller and keyboard
        m_Controllerandkeyboard = asset.FindActionMap("Controller and keyboard", throwIfNotFound: true);
        m_Controllerandkeyboard_Movement = m_Controllerandkeyboard.FindAction("Movement", throwIfNotFound: true);
        m_Controllerandkeyboard_Lookaction = m_Controllerandkeyboard.FindAction("Look action", throwIfNotFound: true);
        m_Controllerandkeyboard_attack = m_Controllerandkeyboard.FindAction("attack", throwIfNotFound: true);
        m_Controllerandkeyboard_LookactionCancelledcont = m_Controllerandkeyboard.FindAction("Look action Cancelled cont", throwIfNotFound: true);
        m_Controllerandkeyboard_LookactionStartCont = m_Controllerandkeyboard.FindAction("Look action Start Cont", throwIfNotFound: true);
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

    // Controller and keyboard
    private readonly InputActionMap m_Controllerandkeyboard;
    private IControllerandkeyboardActions m_ControllerandkeyboardActionsCallbackInterface;
    private readonly InputAction m_Controllerandkeyboard_Movement;
    private readonly InputAction m_Controllerandkeyboard_Lookaction;
    private readonly InputAction m_Controllerandkeyboard_attack;
    private readonly InputAction m_Controllerandkeyboard_LookactionCancelledcont;
    private readonly InputAction m_Controllerandkeyboard_LookactionStartCont;
    public struct ControllerandkeyboardActions
    {
        private @Playerandboatcontrols m_Wrapper;
        public ControllerandkeyboardActions(@Playerandboatcontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Controllerandkeyboard_Movement;
        public InputAction @Lookaction => m_Wrapper.m_Controllerandkeyboard_Lookaction;
        public InputAction @attack => m_Wrapper.m_Controllerandkeyboard_attack;
        public InputAction @LookactionCancelledcont => m_Wrapper.m_Controllerandkeyboard_LookactionCancelledcont;
        public InputAction @LookactionStartCont => m_Wrapper.m_Controllerandkeyboard_LookactionStartCont;
        public InputActionMap Get() { return m_Wrapper.m_Controllerandkeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerandkeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IControllerandkeyboardActions instance)
        {
            if (m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnMovement;
                @Lookaction.started -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookaction;
                @Lookaction.performed -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookaction;
                @Lookaction.canceled -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookaction;
                @attack.started -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnAttack;
                @attack.performed -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnAttack;
                @attack.canceled -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnAttack;
                @LookactionCancelledcont.started -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionCancelledcont;
                @LookactionCancelledcont.performed -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionCancelledcont;
                @LookactionCancelledcont.canceled -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionCancelledcont;
                @LookactionStartCont.started -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionStartCont;
                @LookactionStartCont.performed -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionStartCont;
                @LookactionStartCont.canceled -= m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface.OnLookactionStartCont;
            }
            m_Wrapper.m_ControllerandkeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Lookaction.started += instance.OnLookaction;
                @Lookaction.performed += instance.OnLookaction;
                @Lookaction.canceled += instance.OnLookaction;
                @attack.started += instance.OnAttack;
                @attack.performed += instance.OnAttack;
                @attack.canceled += instance.OnAttack;
                @LookactionCancelledcont.started += instance.OnLookactionCancelledcont;
                @LookactionCancelledcont.performed += instance.OnLookactionCancelledcont;
                @LookactionCancelledcont.canceled += instance.OnLookactionCancelledcont;
                @LookactionStartCont.started += instance.OnLookactionStartCont;
                @LookactionStartCont.performed += instance.OnLookactionStartCont;
                @LookactionStartCont.canceled += instance.OnLookactionStartCont;
            }
        }
    }
    public ControllerandkeyboardActions @Controllerandkeyboard => new ControllerandkeyboardActions(this);
    private int m_ControlsSchemeIndex = -1;
    public InputControlScheme ControlsScheme
    {
        get
        {
            if (m_ControlsSchemeIndex == -1) m_ControlsSchemeIndex = asset.FindControlSchemeIndex("Controls");
            return asset.controlSchemes[m_ControlsSchemeIndex];
        }
    }
    private int m_contcontrolschemeSchemeIndex = -1;
    public InputControlScheme contcontrolschemeScheme
    {
        get
        {
            if (m_contcontrolschemeSchemeIndex == -1) m_contcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("cont control scheme");
            return asset.controlSchemes[m_contcontrolschemeSchemeIndex];
        }
    }
    public interface IControllerandkeyboardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLookaction(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnLookactionCancelledcont(InputAction.CallbackContext context);
        void OnLookactionStartCont(InputAction.CallbackContext context);
    }
}
