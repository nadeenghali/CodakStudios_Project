using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject kratos;
    private Vector3 cameraLoc;
    private bool lockCamera;

    void Start()
    {
        lockCamera = true;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            lockCamera = !lockCamera;
        }

        if(!lockCamera)
        {   this.transform.RotateAround(new Vector3(kratos.transform.position.x, kratos.transform.position.y + 2f, kratos.transform.position.z), new Vector3(0, kratos.transform.position.y, 0), -Input.GetAxis("Mouse X") * 3f);
            this.transform.LookAt(new Vector3(kratos.transform.position.x, kratos.transform.position.y + 2f, kratos.transform.position.z));
        }
    }
}