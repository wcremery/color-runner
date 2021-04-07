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
            ""name"": ""Player"",
            ""id"": ""c4dfe1a9-a3a1-429b-9e1a-7b88bbf28692"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3fa086bf-fb21-4286-9422-4d1d871429d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ColorChange"",
                    ""type"": ""Value"",
                    ""id"": ""677c6a21-7b76-4333-9828-8fe679776b9a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""0dafa2f3-8d87-4176-a6d5-ab9347ffaa1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Red"",
                    ""type"": ""Button"",
                    ""id"": ""08daea33-adff-4532-8334-5b0ebee60451"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""48fd3e3a-9420-4db0-8fa1-16bf05f184f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""c3da2aa5-f9e8-49e8-bd7f-f75704d689bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d04e2ff-c14c-4bd5-b6bb-bea5b9055fc1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap,SlowTap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccff8770-6369-4223-b7c5-7e452414728e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap,SlowTap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d08fb4b8-8381-4bcd-b456-c3978bd4c435"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": ""Tap,SlowTap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5d99930-f827-44bd-9db6-346b507e29a4"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": ""Tap,SlowTap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a4cf278-1890-4020-ab7c-a0eb9cf2cc71"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ee3c03d-b900-42c3-bf2d-578477f80ae4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""387d5bce-2b54-4a16-bdd4-7774e88dc862"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""847f4dfa-a2a5-4343-b725-57978da7e237"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9a5b67e-5de8-4f2a-9d7b-ff61fc05fa73"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": ""Tap,SlowTap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e8b1aa7-f788-46d4-838e-308760c42c39"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8ed0f66-bf22-413e-b407-1c7874a8effa"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""SlowTap,Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""color button"",
                    ""id"": ""536b0346-746a-4ded-ab8f-93c9b55d4490"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""96347cfb-569c-4504-a521-ad30993c9f8d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""52331b76-a089-4d19-b25c-b2ad2574928b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""586c3651-9cf2-479b-a91e-6ab048043ffb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f225159a-d21e-4646-bd05-d8be68dba01e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""color french"",
                    ""id"": ""037b82d2-b240-4277-8831-f989fe9950e9"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fc0bbd28-a9ec-41be-a5ff-4df09f1e905b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f1a9ed04-e746-4c94-a8f5-a1bcdbbf3e81"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""496fc1d2-bde7-44aa-a9ac-53dac8696184"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""34becc09-4dd3-48ae-a121-3cfde2021fc9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""color english"",
                    ""id"": ""fcbcb3c8-5358-4eaf-922d-005563c3e1e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4199cf30-9f39-4651-b0e9-57efa4c4549c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0574798b-b753-4655-9e47-41a0916758f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c74dc313-954d-4df9-9687-cde0728a349e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""60e7a0f5-9983-448d-8121-272fd7e845ef"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""color Button"",
                    ""id"": ""4d027246-90fc-49c3-8d88-763169df0cf7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f22cf903-310c-4326-b150-35ffbed7242a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3bcbf168-c8dc-41c7-a450-0212b271633b"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e5ea7702-0dd4-4273-be0a-232c32d5339b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b9c26198-9ca1-491e-886f-8c9b7cb68343"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""color stick"",
                    ""id"": ""ce99246c-3329-400f-abb6-9b26481f49f0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5aa628b8-5dcc-4692-82be-471df6fc6f64"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24f735ac-6af9-4e3f-93cd-63e0f9127cb1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""26d754f8-9056-4bec-b67b-eb112be473f1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9a0fff7a-409b-4e42-a009-32c6534ed129"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""color stick"",
                    ""id"": ""880d8a5f-6ef4-4155-b705-d4759160ace9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0cc89150-7128-42f7-8171-2e672402a2a4"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""abe0884b-73ac-4a25-97ea-7d1ee49d240a"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a029fea2-c649-4354-b058-efa521fdc390"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d54d8d51-9aa0-4b80-b177-d7afc8dd0ed1"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3fc938eb-1590-45af-957f-0171b149a3d6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ddace99-9fe1-4646-91cf-3010b0e87ea3"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cc0d88a-8bde-476c-8e15-f7dff570ec16"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""709ed983-35ca-4564-b328-f4c259cca42f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9906375-233f-44e7-9965-ccda206ee9dc"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28cd6e40-628c-432f-a22f-a00842317f01"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b90f55ab-49c6-48b1-a810-325052c8a263"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6226672c-ee00-4168-ba83-28c5a7b32b34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61668c08-e504-4013-9025-be1bb2776db1"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""219c371e-b6e3-4bbe-8ebc-dcb4f914c4e7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dadae3c2-6224-436d-bbc1-c21e2048a35d"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07c93a65-942b-4aec-ab04-623613b0d572"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13452a7-4c98-4941-b00e-35834ccb4ade"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c6a98b9-65f8-4dd6-962a-0346ad49fe33"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed92473f-3db8-4ceb-8812-06423f8a5567"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ceec4580-882d-48c8-a51c-cd11b8790cbe"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Left"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""127dbc5f-3abc-4574-a903-ec17b4c1659c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a43dffb-4c53-44c5-940b-ba0ba1035b74"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad Right"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad Left"",
            ""bindingGroup"": ""Gamepad Left"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad Right"",
            ""bindingGroup"": ""Gamepad Right"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_ColorChange = m_Player.FindAction("ColorChange", throwIfNotFound: true);
        m_Player_Yellow = m_Player.FindAction("Yellow", throwIfNotFound: true);
        m_Player_Red = m_Player.FindAction("Red", throwIfNotFound: true);
        m_Player_Green = m_Player.FindAction("Green", throwIfNotFound: true);
        m_Player_Blue = m_Player.FindAction("Blue", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_ColorChange;
    private readonly InputAction m_Player_Yellow;
    private readonly InputAction m_Player_Red;
    private readonly InputAction m_Player_Green;
    private readonly InputAction m_Player_Blue;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @ColorChange => m_Wrapper.m_Player_ColorChange;
        public InputAction @Yellow => m_Wrapper.m_Player_Yellow;
        public InputAction @Red => m_Wrapper.m_Player_Red;
        public InputAction @Green => m_Wrapper.m_Player_Green;
        public InputAction @Blue => m_Wrapper.m_Player_Blue;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @ColorChange.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColorChange;
                @ColorChange.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColorChange;
                @ColorChange.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnColorChange;
                @Yellow.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYellow;
                @Red.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRed;
                @Red.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRed;
                @Red.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRed;
                @Green.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGreen;
                @Blue.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlue;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ColorChange.started += instance.OnColorChange;
                @ColorChange.performed += instance.OnColorChange;
                @ColorChange.canceled += instance.OnColorChange;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
                @Red.started += instance.OnRed;
                @Red.performed += instance.OnRed;
                @Red.canceled += instance.OnRed;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadLeftSchemeIndex = -1;
    public InputControlScheme GamepadLeftScheme
    {
        get
        {
            if (m_GamepadLeftSchemeIndex == -1) m_GamepadLeftSchemeIndex = asset.FindControlSchemeIndex("Gamepad Left");
            return asset.controlSchemes[m_GamepadLeftSchemeIndex];
        }
    }
    private int m_GamepadRightSchemeIndex = -1;
    public InputControlScheme GamepadRightScheme
    {
        get
        {
            if (m_GamepadRightSchemeIndex == -1) m_GamepadRightSchemeIndex = asset.FindControlSchemeIndex("Gamepad Right");
            return asset.controlSchemes[m_GamepadRightSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnColorChange(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
        void OnRed(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
    }
}
