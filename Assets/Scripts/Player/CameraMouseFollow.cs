using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMouseFollow : MonoBehaviour
{
    private Camera mainCamera;
    private float cameraMoveSpeed = 0.0001f;
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        if (mainCamera == null)
        {
            Debug.Log("Camera not found");
        }
    }

    void Update()
    {
        //Debug.Log("Mouse Pos:"+ Mouse.current.position.x.value + "-" + Mouse.current.position.y.value);
        PanCameratoMouse();
    }

    public void RecenterCamera(Vector3 playerLocation) 
    {
        mainCamera.transform.position = new Vector3(playerLocation.x , mainCamera.transform.position.y, playerLocation.z);
    }

    private void PanCameratoMouse()
    {
        if (MouseToucingWidthEdge())
        {
            mainCamera.transform.position = new Vector3(mainCamera.transform.position.x + Screen.currentResolution.width * cameraMoveSpeed, mainCamera.transform.position.y, mainCamera.transform.position.z);
        }
        if (MouseTouchingHeightEdge())
        {
            mainCamera.transform.position = new Vector3(mainCamera.transform.position.x , mainCamera.transform.position.y, mainCamera.transform.position.z + Screen.currentResolution.height * cameraMoveSpeed);
        }
    }

    private bool MouseToucingWidthEdge()
    {
        if (Mouse.current.position.x.value >= Screen.currentResolution.width - 1)
        {
            cameraMoveSpeed = MathF.Abs(cameraMoveSpeed);
            return true;
        }
        else if(Mouse.current.position.x.value <= 0)
        {
            cameraMoveSpeed = cameraMoveSpeed > 0 ? cameraMoveSpeed * -1f : cameraMoveSpeed;
            return true;
        }
        return false;
    }

    private bool MouseTouchingHeightEdge() 
    {
        if (Mouse.current.position.y.value >= Screen.currentResolution.height - 1)
        {
            cameraMoveSpeed = MathF.Abs(cameraMoveSpeed);
            return true;
        }
        else if (Mouse.current.position.y.value <= 0) 
        {
            cameraMoveSpeed = cameraMoveSpeed > 0 ? cameraMoveSpeed * -1f : cameraMoveSpeed;
            return true;
        }
        return false;
    }
}
