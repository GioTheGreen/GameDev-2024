using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
    public float sensitivity;
    public float Speed;

    void Update()
    {
        if (Input.GetMouseButton(1)) //if we are holding right click
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            Vector3 mouseInput = new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            transform.Rotate(mouseInput * sensitivity);
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 0);

            Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            transform.Translate(input * Speed * Time.deltaTime);

        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }
}
