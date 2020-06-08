// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""e3b499ba-9c83-494a-ad3b-750ed1b1c7fb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2196b3d2-1299-409d-b93c-09e0d5425402"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dee165c7-3e16-4921-a6da-35a9e3f30e32"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""1f721e62-c5ce-418f-92fb-e32dfb8ac9de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""07955602-2e8c-4d88-aef9-2746df940cf3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ChooseTools"",
                    ""type"": ""Value"",
                    ""id"": ""d35f2ce0-f34d-46d2-b633-d8be09718578"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""460b42e3-b511-4f5e-b743-8e7643c1d9ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1657a394-9072-4e9d-960a-de1fc81f15e8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7c7e41f3-80ce-4d42-9063-a9575f68677a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fb754ac0-f466-4473-8ea3-1c181a3a9ee2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6d9f6eeb-8330-4d78-90c2-f2868237fa87"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a496de7-893d-4a51-850d-77015a5950cf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a25f3d27-ed47-4119-b094-7bc90e5d37bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1a8712a3-7ac8-4f21-b6f8-adf3f49bc7f2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b0c446d-fa47-46b4-b7b9-c34c7b1ee07f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0baf62c1-ffe2-4834-bdbf-6d938c3bc5d3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc23c64-e93b-43e5-8eac-41fee48c2faa"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1320ff40-7b98-47be-9169-53c11ce8a53f"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""ChooseTools"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b525af8-ca72-4e09-aff9-9ce1484b4c8c"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChooseTools"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8eabcca-1a36-4a9d-adfa-08137872a128"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de05ac9c-127f-4b89-9818-ec7033518eb3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23cd095c-6ab5-4b0b-944f-63a946083082"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c4e001c-a91c-4b15-8d6d-2d617253bac5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""5c571e63-ed08-4bf2-a490-ef11573f7350"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""81a1a885-14ee-4e24-afd2-6253c2d39008"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f2c757bc-7ec9-4fa3-99e7-00a956878c8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e8ac7e26-c60a-41fe-883c-962a6d289357"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ChooseTools"",
                    ""type"": ""Value"",
                    ""id"": ""119bf12c-fd9e-4b1e-b025-4987b77d8294"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ef66fd04-589a-483d-838f-beb5f19fec15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""08ab7407-788d-4016-93da-11602e604e30"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6536110f-169f-4549-9c4a-5676e8b00ca6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7163acc0-2ae2-44bf-ac2f-aeb7fd3b9dfb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""adfd15a6-da43-44aa-b843-a4b45f634cca"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50ac3828-58e1-4cb8-b578-3bbb559d0d44"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fc9ba587-cdb8-434c-be2e-5041bb4568bf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""acfa23a4-0da4-49e2-afa6-1f6aeb709e0f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""80dd49fd-3b06-4e63-8df2-11395365a5fe"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""674f9082-553f-4b13-984f-6d3f70d85429"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c73cc2a2-5a00-471d-aaed-81c1d3c491c2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5c64c1e-1690-41c3-ad8c-5a4f2861ec23"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eac654c-b97d-4d21-96a4-fb7380827016"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""ChooseTools"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56666bad-9798-492e-b870-e8df4f57c7f4"",
                    ""path"": ""<Gamepad>/dpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ChooseTools"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20b67a25-b511-40f9-87fe-f9c988a2aa15"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af4003ca-39d2-4f30-bd9b-7d4b8ff0aa5c"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8102373-a72d-45c9-a056-856910b018f1"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard+Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard+Mouse"",
            ""bindingGroup"": ""Keyboard+Mouse"",
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
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Move = m_Player1.FindAction("Move", throwIfNotFound: true);
        m_Player1_Look = m_Player1.FindAction("Look", throwIfNotFound: true);
        m_Player1_Interact = m_Player1.FindAction("Interact", throwIfNotFound: true);
        m_Player1_Fire = m_Player1.FindAction("Fire", throwIfNotFound: true);
        m_Player1_ChooseTools = m_Player1.FindAction("ChooseTools", throwIfNotFound: true);
        m_Player1_Jump = m_Player1.FindAction("Jump", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        m_Player2_Interact = m_Player2.FindAction("Interact", throwIfNotFound: true);
        m_Player2_Fire = m_Player2.FindAction("Fire", throwIfNotFound: true);
        m_Player2_ChooseTools = m_Player2.FindAction("ChooseTools", throwIfNotFound: true);
        m_Player2_Jump = m_Player2.FindAction("Jump", throwIfNotFound: true);
        m_Player2_Look = m_Player2.FindAction("Look", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Move;
    private readonly InputAction m_Player1_Look;
    private readonly InputAction m_Player1_Interact;
    private readonly InputAction m_Player1_Fire;
    private readonly InputAction m_Player1_ChooseTools;
    private readonly InputAction m_Player1_Jump;
    public struct Player1Actions
    {
        private @PlayerInput m_Wrapper;
        public Player1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1_Move;
        public InputAction @Look => m_Wrapper.m_Player1_Look;
        public InputAction @Interact => m_Wrapper.m_Player1_Interact;
        public InputAction @Fire => m_Wrapper.m_Player1_Fire;
        public InputAction @ChooseTools => m_Wrapper.m_Player1_ChooseTools;
        public InputAction @Jump => m_Wrapper.m_Player1_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Interact.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnInteract;
                @Fire.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFire;
                @ChooseTools.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnChooseTools;
                @ChooseTools.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnChooseTools;
                @ChooseTools.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnChooseTools;
                @Jump.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @ChooseTools.started += instance.OnChooseTools;
                @ChooseTools.performed += instance.OnChooseTools;
                @ChooseTools.canceled += instance.OnChooseTools;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    private readonly InputAction m_Player2_Interact;
    private readonly InputAction m_Player2_Fire;
    private readonly InputAction m_Player2_ChooseTools;
    private readonly InputAction m_Player2_Jump;
    private readonly InputAction m_Player2_Look;
    public struct Player2Actions
    {
        private @PlayerInput m_Wrapper;
        public Player2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputAction @Interact => m_Wrapper.m_Player2_Interact;
        public InputAction @Fire => m_Wrapper.m_Player2_Fire;
        public InputAction @ChooseTools => m_Wrapper.m_Player2_ChooseTools;
        public InputAction @Jump => m_Wrapper.m_Player2_Jump;
        public InputAction @Look => m_Wrapper.m_Player2_Look;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnInteract;
                @Fire.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFire;
                @ChooseTools.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnChooseTools;
                @ChooseTools.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnChooseTools;
                @ChooseTools.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnChooseTools;
                @Jump.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @ChooseTools.started += instance.OnChooseTools;
                @ChooseTools.performed += instance.OnChooseTools;
                @ChooseTools.canceled += instance.OnChooseTools;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard+Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnChooseTools(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnChooseTools(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
