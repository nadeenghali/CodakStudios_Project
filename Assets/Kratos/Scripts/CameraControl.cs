using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject kratos;
    private Vector3 cameraLoc;

    void Start()
    {
        cameraLoc = new Vector3(kratos.transform.position.x, kratos.transform.position.y + 3f , kratos.transform.position.z-3.5f);
    }

    void LateUpdate()
    {
        cameraLoc = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 4.5f, Vector3.up) * cameraLoc;
        this.transform.position = kratos.transform.position + cameraLoc;
        this.transform.LookAt(new Vector3(kratos.transform.position.x, 2f , kratos.transform.position.z));
    }
}