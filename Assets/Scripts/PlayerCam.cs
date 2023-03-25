using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse x input
        float mouseX = Input.GetAxisRaw("Mouse x") * Time.deltaTime * sensX;
        //get mouse y
        float mouseY = Input.GetAxisRaw("Mouse y") * Time.deltaTime * sensY;

        yRotation += mouseY;
        xRotation -= mouseX;

    }
}
