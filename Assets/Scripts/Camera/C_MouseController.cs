using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_MouseController : MonoBehaviour
{


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * GameManager.gM.mouseCameraSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * GameManager.gM.mouseCameraSensitivity * Time.deltaTime;

        GameManager.gM.cameraXRotation -= mouseY;
        GameManager.gM.cameraXRotation = Mathf.Clamp(GameManager.gM.cameraXRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(GameManager.gM.cameraXRotation,0,0);
        GameManager.gM.pTransform.Rotate(Vector3.up * mouseX);
    }
}
