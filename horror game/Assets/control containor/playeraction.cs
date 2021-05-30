// GENERATED AUTOMATICALLY FROM 'Assets/control containor/playeraction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Playeraction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playeraction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playeraction"",
    ""maps"": [
        {
            ""name"": ""player keyboard contols"",
            ""id"": ""f1509a7a-814c-4c58-acf0-ca75cb07329b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""787a3d6f-b735-4900-8bd2-060db093e54a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouse"",
                    ""type"": ""PassThrough"",
                    ""id"": ""684c78e2-5f1f-4d61-82e9-e4f9702cd4b0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""fire"",
                    ""type"": ""Button"",
                    ""id"": ""4ff00aed-88ce-45a2-bc6a-fa082cbb9b1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""05bb7dcf-2ee8-46f5-b60f-27ec10197995"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""24a71245-362f-4dab-87a7-687bf98de652"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""d82868af-e9b8-4219-b107-4f5ed08c9527"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""weapon wheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""191e7c57-efa5-48dd-b2f2-08a9bb8db982"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sound emmiter"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eb0005d3-e50d-4efa-ae72-ea66abe8baea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""46c4807e-2645-4f13-b9db-85677305d4ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""lockon"",
                    ""type"": ""Button"",
                    ""id"": ""bdf67c2f-2348-4954-bffd-90453168cfef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                },
                {
                    ""name"": ""flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""ec285f85-e163-4b2c-b765-3d0110d4d3b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8509482c-83c9-4f1b-b782-d981b6d65d41"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": ""New control scheme"",
                    ""action"": ""mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e406746d-a7b8-4b2f-b75d-03acf88e1958"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f46f387-0d33-42ec-9c77-23cb93b4ace2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""bdcf7d58-3fc8-49f6-95d4-24f7065635b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6e383ef4-fa5d-4d2d-a0d2-0d867afe7715"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eebaa08d-bf88-4302-84f1-e7e17e5e89af"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0d0453e3-73cb-4a57-b613-9a0e955e6c49"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1a36244e-ae6a-4529-8b50-42e8457fbb09"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fbc5440f-d497-4739-ab11-48ce7075722f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""514c6b6d-f9ae-4e4c-b569-da0f4ac6a6f6"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e41616d2-5c7c-400c-bc75-5f42dc6a8f77"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.1,max=0.1),Normalize(max=1),Clamp(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""weapon wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2ccd490a-efc0-4a78-a942-bfb1d3936e33"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound emmiter"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2e98f04d-a0b3-4bee-9dea-21e098a5ade1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound emmiter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cba13c6b-99c2-4f67-80e5-8fb98acc7f35"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound emmiter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b284e941-8611-418e-9914-a1b52e1ee345"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound emmiter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7e1b254f-5890-4490-b8b5-6546506b4304"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sound emmiter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21c8512d-82a4-4608-9017-dc2adc40f621"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61a18fd1-690d-4ae5-8004-6d462beffc0e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lockon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26699681-9461-4b7d-a0c0-f4ff073fc267"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press(pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player keyboard contols
        m_playerkeyboardcontols = asset.FindActionMap("player keyboard contols", throwIfNotFound: true);
        m_playerkeyboardcontols_Movement = m_playerkeyboardcontols.FindAction("Movement", throwIfNotFound: true);
        m_playerkeyboardcontols_mouse = m_playerkeyboardcontols.FindAction("mouse", throwIfNotFound: true);
        m_playerkeyboardcontols_fire = m_playerkeyboardcontols.FindAction("fire", throwIfNotFound: true);
        m_playerkeyboardcontols_jump = m_playerkeyboardcontols.FindAction("jump", throwIfNotFound: true);
        m_playerkeyboardcontols_Sprint = m_playerkeyboardcontols.FindAction("Sprint", throwIfNotFound: true);
        m_playerkeyboardcontols_Crouch = m_playerkeyboardcontols.FindAction("Crouch", throwIfNotFound: true);
        m_playerkeyboardcontols_weaponwheel = m_playerkeyboardcontols.FindAction("weapon wheel", throwIfNotFound: true);
        m_playerkeyboardcontols_soundemmiter = m_playerkeyboardcontols.FindAction("sound emmiter", throwIfNotFound: true);
        m_playerkeyboardcontols_Reload = m_playerkeyboardcontols.FindAction("Reload", throwIfNotFound: true);
        m_playerkeyboardcontols_lockon = m_playerkeyboardcontols.FindAction("lockon", throwIfNotFound: true);
        m_playerkeyboardcontols_flashlight = m_playerkeyboardcontols.FindAction("flashlight", throwIfNotFound: true);
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

    // player keyboard contols
    private readonly InputActionMap m_playerkeyboardcontols;
    private IPlayerkeyboardcontolsActions m_PlayerkeyboardcontolsActionsCallbackInterface;
    private readonly InputAction m_playerkeyboardcontols_Movement;
    private readonly InputAction m_playerkeyboardcontols_mouse;
    private readonly InputAction m_playerkeyboardcontols_fire;
    private readonly InputAction m_playerkeyboardcontols_jump;
    private readonly InputAction m_playerkeyboardcontols_Sprint;
    private readonly InputAction m_playerkeyboardcontols_Crouch;
    private readonly InputAction m_playerkeyboardcontols_weaponwheel;
    private readonly InputAction m_playerkeyboardcontols_soundemmiter;
    private readonly InputAction m_playerkeyboardcontols_Reload;
    private readonly InputAction m_playerkeyboardcontols_lockon;
    private readonly InputAction m_playerkeyboardcontols_flashlight;
    public struct PlayerkeyboardcontolsActions
    {
        private @Playeraction m_Wrapper;
        public PlayerkeyboardcontolsActions(@Playeraction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_playerkeyboardcontols_Movement;
        public InputAction @mouse => m_Wrapper.m_playerkeyboardcontols_mouse;
        public InputAction @fire => m_Wrapper.m_playerkeyboardcontols_fire;
        public InputAction @jump => m_Wrapper.m_playerkeyboardcontols_jump;
        public InputAction @Sprint => m_Wrapper.m_playerkeyboardcontols_Sprint;
        public InputAction @Crouch => m_Wrapper.m_playerkeyboardcontols_Crouch;
        public InputAction @weaponwheel => m_Wrapper.m_playerkeyboardcontols_weaponwheel;
        public InputAction @soundemmiter => m_Wrapper.m_playerkeyboardcontols_soundemmiter;
        public InputAction @Reload => m_Wrapper.m_playerkeyboardcontols_Reload;
        public InputAction @lockon => m_Wrapper.m_playerkeyboardcontols_lockon;
        public InputAction @flashlight => m_Wrapper.m_playerkeyboardcontols_flashlight;
        public InputActionMap Get() { return m_Wrapper.m_playerkeyboardcontols; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerkeyboardcontolsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerkeyboardcontolsActions instance)
        {
            if (m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMovement;
                @mouse.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMouse;
                @mouse.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMouse;
                @mouse.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnMouse;
                @fire.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFire;
                @fire.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFire;
                @fire.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFire;
                @jump.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnCrouch;
                @weaponwheel.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnWeaponwheel;
                @weaponwheel.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnWeaponwheel;
                @weaponwheel.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnWeaponwheel;
                @soundemmiter.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSoundemmiter;
                @soundemmiter.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSoundemmiter;
                @soundemmiter.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnSoundemmiter;
                @Reload.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnReload;
                @lockon.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnLockon;
                @lockon.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnLockon;
                @lockon.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnLockon;
                @flashlight.started -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFlashlight;
                @flashlight.performed -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFlashlight;
                @flashlight.canceled -= m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface.OnFlashlight;
            }
            m_Wrapper.m_PlayerkeyboardcontolsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @mouse.started += instance.OnMouse;
                @mouse.performed += instance.OnMouse;
                @mouse.canceled += instance.OnMouse;
                @fire.started += instance.OnFire;
                @fire.performed += instance.OnFire;
                @fire.canceled += instance.OnFire;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @weaponwheel.started += instance.OnWeaponwheel;
                @weaponwheel.performed += instance.OnWeaponwheel;
                @weaponwheel.canceled += instance.OnWeaponwheel;
                @soundemmiter.started += instance.OnSoundemmiter;
                @soundemmiter.performed += instance.OnSoundemmiter;
                @soundemmiter.canceled += instance.OnSoundemmiter;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @lockon.started += instance.OnLockon;
                @lockon.performed += instance.OnLockon;
                @lockon.canceled += instance.OnLockon;
                @flashlight.started += instance.OnFlashlight;
                @flashlight.performed += instance.OnFlashlight;
                @flashlight.canceled += instance.OnFlashlight;
            }
        }
    }
    public PlayerkeyboardcontolsActions @playerkeyboardcontols => new PlayerkeyboardcontolsActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IPlayerkeyboardcontolsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnWeaponwheel(InputAction.CallbackContext context);
        void OnSoundemmiter(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnLockon(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
    }
}
