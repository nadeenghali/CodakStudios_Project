using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject kratos;
    private Vector3 cameraLoc;

    void Start()
    {
    }

    void FixedUpdate()
    {
        this.transform.RotateAround(new Vector3(kratos.transform.position.x, kratos.transform.position.y + 2f, kratos.transform.position.z), new Vector3(0, kratos.transform.position.y, 0), Input.GetAxis("Mouse X") * 3f);
        this.transform.LookAt(new Vector3(kratos.transform.position.x, kratos.transform.position.y + 1.5f, kratos.transform.position.z));
    }
}