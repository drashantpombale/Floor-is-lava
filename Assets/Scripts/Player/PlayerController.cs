using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent UnitBody;

    [SerializeField]
    private ParticleSystem ClickEffect;

    private PlayerInputControls movementInputAction;

    private CameraMouseFollow cameraComp;
    private void Awake()
    {
        movementInputAction = new PlayerInputControls();
        
        movementInputAction.Movement.Move.performed += MovePlayer;
        movementInputAction.Misc.Recenter.performed += RecenterCamera;

        cameraComp = GameObject.FindFirstObjectByType<CameraMouseFollow>();
    }

    private void RecenterCamera(InputAction.CallbackContext obj)
    {
        if (cameraComp != null) 
        {
            cameraComp.RecenterCamera(this.transform.position);
        }
    }

    private void MovePlayer(InputAction.CallbackContext obj)
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
        {
            UnitBody.destination = hit.point;
            Instantiate(ClickEffect, hit.point+= new Vector3(0,0.1f,0), ClickEffect.transform.rotation);
        }
    }

    private void OnEnable()
    {
        movementInputAction.Enable();
    }

    private void OnDisable()
    {
        movementInputAction.Disable();
    }
}
