using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent UnitBody;

    [SerializeField]
    private ParticleSystem ClickEffect;

    private PlayerInputControls playerInputAction;

    private CameraMouseFollow cameraComp;

    private FireballSpawner fireballSpawner;

    public float turnRate = 8f;
    private void Awake()
    {
        playerInputAction = new PlayerInputControls();

        fireballSpawner = GetComponentInChildren<FireballSpawner>();

        playerInputAction.Movement.Move.performed += MovePlayer;
        playerInputAction.Misc.Recenter.performed += RecenterCamera;

        playerInputAction.Abilities.Ability1.performed += SpawnFireball;

        cameraComp = GameObject.FindFirstObjectByType<CameraMouseFollow>();

    }

    private void SpawnFireball(InputAction.CallbackContext obj)
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            transform.LookAt(hit.point);
            fireballSpawner.ShootFireball(hit.point);
        }
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

    void FaceTarget()
    {
        if (transform.position != (UnitBody.destination += new Vector3(0, 1, 0)))
        {
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(UnitBody.velocity.x, 0, UnitBody.velocity.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnRate);
        }
    }

    private void OnEnable()
    {
        playerInputAction.Enable();
    }

    private void OnDisable()
    {
        playerInputAction.Disable();
    }

    private void Update()
    {
        FaceTarget();
    }

}
