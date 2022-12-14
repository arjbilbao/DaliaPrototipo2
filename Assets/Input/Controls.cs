//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Input/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Pcontroller"",
            ""id"": ""ed892967-7a6d-4d5e-be20-0dbc06f3e816"",
            ""actions"": [
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""52471fe0-812e-4c2b-8ab6-98e1420def5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""0ad1de57-d9cf-493a-bc3f-dd5e2d861d7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""df2338e6-0b86-4a9d-9503-706c51d8bb83"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""15af1656-fee9-4b41-958d-c0cd7e1b7607"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4616b56d-4d82-4a6c-b9a6-4254cb159036"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""d3078e77-b8d9-4ec8-8241-ea82fc60a23b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LB"",
                    ""type"": ""Button"",
                    ""id"": ""7550e163-c0b1-4b16-af61-698bafab4f50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""0f3fac55-aafc-4679-91fc-bdab2100ee3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""View"",
                    ""type"": ""Button"",
                    ""id"": ""50771468-93b2-47b9-93eb-9b5ea170e3bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ba04d771-f3e1-4d00-931b-c1259b3f6ba9"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8581184-6ffb-408a-bd41-7a87fd2c25b7"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d41f54d2-2c89-4e7c-b439-9e07a49a8cac"",
                    ""path"": ""<SwitchProControllerHID>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7105e24-baba-4f24-9f8a-a87dd4026f16"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3848745e-cb7a-4ad4-b284-71f58fde5dc5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b653017-f225-43f1-b635-e61da66e23e5"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6d3175c-24e5-4e5f-ab29-4e51b6b013a4"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52899b8b-6444-45af-867a-8cbe8273628b"",
                    ""path"": ""<SwitchProControllerHID>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab3881aa-67d3-44c3-a719-69ac814124fa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e43c005-2d35-4f4f-9b1b-1a005266cb09"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6759e1db-79aa-4c2a-92c7-4b9b7e64e7ef"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""915d24ce-6b97-4d97-b983-08e5d425bed7"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e40e2570-8ec2-473d-9595-5851da1d3a76"",
                    ""path"": ""<SwitchProControllerHID>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e0f1f60-21c5-49b2-8e69-d2cd8e13fa30"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6289add-1a6f-4380-85b9-3ed648e69820"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fae9ed05-681f-4bbb-aa6c-d0833157bcf1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcb2441c-e991-4ec6-abaa-7473e0c3ed4d"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4eb5993-065e-4764-a75a-a96bb40c4621"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca482439-2cfd-4dc3-bc7e-36b6208d918a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9018f485-23b0-408e-8da7-a62ddda483a1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34642483-6325-42ed-91dc-d1c3032e2709"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""200f5dcc-d1a6-40a2-b19c-ec7b2083831b"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9ac0bf1-0f63-4897-9513-855adfbd5227"",
                    ""path"": ""<SwitchProControllerHID>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d913870-22be-4f08-a62a-3b2a81585d84"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""80de7d82-8d2d-4679-907e-67ad6bd3b855"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8b064eef-6e14-4201-a842-553199b64e81"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""25f88b21-3d34-49bb-acf8-a72466011278"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3cdbbdc3-cbd7-4085-998b-f10bff98808e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d749c8ad-4972-4cf4-9601-b0ad7906bca2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d8d56a80-1066-4c6f-9f08-3cd87be03b11"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46b1375b-060d-4ffa-b120-f8f85b086b1f"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a2bec1c-5611-4626-8371-6a301f15e118"",
                    ""path"": ""<SwitchProControllerHID>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c05b3c-dd5c-4133-afe0-e28f9e2ab376"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8751936-594f-4713-8698-9b202bab0f63"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""121215ab-9173-4a90-83e4-adfed6aa9d7f"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a7e8ab5-1638-4799-a846-26bdd8e2c39e"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73275c01-2138-40f9-bbf0-3b478578d019"",
                    ""path"": ""<SwitchProControllerHID>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""936b121a-8baa-4c6a-b277-e5ef49eef96d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d11bfdf8-8427-4b41-bf8c-bec632a82ce4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0cd3774-a4aa-4138-b419-21f163dcbc3e"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5be76ee9-d406-4cdb-a2af-598182dd9227"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e528e93b-951a-4c08-b1a7-2e147310c884"",
                    ""path"": ""<SwitchProControllerHID>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c724975d-33c3-40d0-8fd1-a4872a86698a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acd8e5df-55fb-404d-852c-ccc9ec8b3b17"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9e3eeda-bc2f-4cd7-94a7-008451af803d"",
                    ""path"": ""<XInputController>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9b995ed-189e-4e9f-b467-7b11de1bce64"",
                    ""path"": ""<DualShockGamepad>/touchpadButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37ae9fbd-3ac9-44cf-a856-d4a341df123a"",
                    ""path"": ""<SwitchProControllerHID>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""510d27d9-44ea-4f66-bb7b-c8e991c064e4"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9941a26-9426-4abc-9453-2734fe9ae394"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Pcontroller
        m_Pcontroller = asset.FindActionMap("Pcontroller", throwIfNotFound: true);
        m_Pcontroller_South = m_Pcontroller.FindAction("South", throwIfNotFound: true);
        m_Pcontroller_West = m_Pcontroller.FindAction("West", throwIfNotFound: true);
        m_Pcontroller_North = m_Pcontroller.FindAction("North", throwIfNotFound: true);
        m_Pcontroller_East = m_Pcontroller.FindAction("East", throwIfNotFound: true);
        m_Pcontroller_LeftStick = m_Pcontroller.FindAction("LeftStick", throwIfNotFound: true);
        m_Pcontroller_RB = m_Pcontroller.FindAction("RB", throwIfNotFound: true);
        m_Pcontroller_LB = m_Pcontroller.FindAction("LB", throwIfNotFound: true);
        m_Pcontroller_Menu = m_Pcontroller.FindAction("Menu", throwIfNotFound: true);
        m_Pcontroller_View = m_Pcontroller.FindAction("View", throwIfNotFound: true);
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

    // Pcontroller
    private readonly InputActionMap m_Pcontroller;
    private IPcontrollerActions m_PcontrollerActionsCallbackInterface;
    private readonly InputAction m_Pcontroller_South;
    private readonly InputAction m_Pcontroller_West;
    private readonly InputAction m_Pcontroller_North;
    private readonly InputAction m_Pcontroller_East;
    private readonly InputAction m_Pcontroller_LeftStick;
    private readonly InputAction m_Pcontroller_RB;
    private readonly InputAction m_Pcontroller_LB;
    private readonly InputAction m_Pcontroller_Menu;
    private readonly InputAction m_Pcontroller_View;
    public struct PcontrollerActions
    {
        private @Controls m_Wrapper;
        public PcontrollerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @South => m_Wrapper.m_Pcontroller_South;
        public InputAction @West => m_Wrapper.m_Pcontroller_West;
        public InputAction @North => m_Wrapper.m_Pcontroller_North;
        public InputAction @East => m_Wrapper.m_Pcontroller_East;
        public InputAction @LeftStick => m_Wrapper.m_Pcontroller_LeftStick;
        public InputAction @RB => m_Wrapper.m_Pcontroller_RB;
        public InputAction @LB => m_Wrapper.m_Pcontroller_LB;
        public InputAction @Menu => m_Wrapper.m_Pcontroller_Menu;
        public InputAction @View => m_Wrapper.m_Pcontroller_View;
        public InputActionMap Get() { return m_Wrapper.m_Pcontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PcontrollerActions set) { return set.Get(); }
        public void SetCallbacks(IPcontrollerActions instance)
        {
            if (m_Wrapper.m_PcontrollerActionsCallbackInterface != null)
            {
                @South.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnSouth;
                @West.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnWest;
                @North.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnNorth;
                @East.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnEast;
                @LeftStick.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLeftStick;
                @RB.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnRB;
                @LB.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLB;
                @LB.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLB;
                @LB.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnLB;
                @Menu.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnMenu;
                @View.started -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_PcontrollerActionsCallbackInterface.OnView;
            }
            m_Wrapper.m_PcontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @LB.started += instance.OnLB;
                @LB.performed += instance.OnLB;
                @LB.canceled += instance.OnLB;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
            }
        }
    }
    public PcontrollerActions @Pcontroller => new PcontrollerActions(this);
    public interface IPcontrollerActions
    {
        void OnSouth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnLB(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
    }
}
