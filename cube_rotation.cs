using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_rotation : MonoBehaviour
{
    private float sensitivityX = 1f, sensitivityY = 1f;

    void Update()
    {
        XRotation();
        YRotation();
    }

    private void XRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 rotation = transform.localEulerAngles;
        rotation.y += mouseX * sensitivityX;
        transform.localEulerAngles = rotation;
    }

    private void YRotation()
    {
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 rotation = transform.localEulerAngles;
        rotation.x += mouseY * sensitivityY;
        transform.localEulerAngles = rotation;
    }
}