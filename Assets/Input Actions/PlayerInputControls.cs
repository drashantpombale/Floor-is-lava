//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Input Actions/PlayerInputControls.inputactions
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

public partial class @PlayerInputControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""3d688db2-4b3d-4a65-a25f-699ff6c33208"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9d8aaa4a-693a-47ab-9f06-392eed71304d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6db3d88a-de47-4d51-bcde-659982086e38"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Misc"",
            ""id"": ""c4493fc6-c4e7-4832-8e82-b08b9a4b19f1"",
            ""actions"": [
                {
                    ""name"": ""Recenter"",
                    ""type"": ""Button"",
                    ""id"": ""657a1837-692c-4db1-9fd1-e671f9404687"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""44d16f8b-9819-4925-b28d-2a1b2bd5a6bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4edaa0bd-01bc-4131-86c9-93dc475009bf"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Recenter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c03decca-1df9-47a3-a6b7-d19c97b5a415"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        // Misc
        m_Misc = asset.FindActionMap("Misc", throwIfNotFound: true);
        m_Misc_Recenter = m_Misc.FindAction("Recenter", throwIfNotFound: true);
        m_Misc_SelectCharacter = m_Misc.FindAction("SelectCharacter", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Move;
    public struct MovementActions
    {
        private @PlayerInputControls m_Wrapper;
        public MovementActions(@PlayerInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Misc
    private readonly InputActionMap m_Misc;
    private List<IMiscActions> m_MiscActionsCallbackInterfaces = new List<IMiscActions>();
    private readonly InputAction m_Misc_Recenter;
    private readonly InputAction m_Misc_SelectCharacter;
    public struct MiscActions
    {
        private @PlayerInputControls m_Wrapper;
        public MiscActions(@PlayerInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Recenter => m_Wrapper.m_Misc_Recenter;
        public InputAction @SelectCharacter => m_Wrapper.m_Misc_SelectCharacter;
        public InputActionMap Get() { return m_Wrapper.m_Misc; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MiscActions set) { return set.Get(); }
        public void AddCallbacks(IMiscActions instance)
        {
            if (instance == null || m_Wrapper.m_MiscActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MiscActionsCallbackInterfaces.Add(instance);
            @Recenter.started += instance.OnRecenter;
            @Recenter.performed += instance.OnRecenter;
            @Recenter.canceled += instance.OnRecenter;
            @SelectCharacter.started += instance.OnSelectCharacter;
            @SelectCharacter.performed += instance.OnSelectCharacter;
            @SelectCharacter.canceled += instance.OnSelectCharacter;
        }

        private void UnregisterCallbacks(IMiscActions instance)
        {
            @Recenter.started -= instance.OnRecenter;
            @Recenter.performed -= instance.OnRecenter;
            @Recenter.canceled -= instance.OnRecenter;
            @SelectCharacter.started -= instance.OnSelectCharacter;
            @SelectCharacter.performed -= instance.OnSelectCharacter;
            @SelectCharacter.canceled -= instance.OnSelectCharacter;
        }

        public void RemoveCallbacks(IMiscActions instance)
        {
            if (m_Wrapper.m_MiscActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMiscActions instance)
        {
            foreach (var item in m_Wrapper.m_MiscActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MiscActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MiscActions @Misc => new MiscActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IMiscActions
    {
        void OnRecenter(InputAction.CallbackContext context);
        void OnSelectCharacter(InputAction.CallbackContext context);
    }
}