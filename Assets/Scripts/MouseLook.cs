using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 5.0f;
    public Vector3 initialCameraRotation = new Vector3(0.0f, 0.0f, 0.0f);

    private Transform cameraTransform;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraTransform = GetComponentInChildren<Camera>().transform;
        cameraTransform.localRotation = Quaternion.Euler(initialCameraRotation);
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void OnApplicationPause(bool isPaused)
    {
        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;

        Quaternion yRotation = Quaternion.Euler(0.0f, horizontal * Time.deltaTime, 0.0f);
        Quaternion xRotation = Quaternion.Euler(-vertical * Time.deltaTime, 0.0f, 0.0f);

        transform.Rotate(yRotation.eulerAngles);
        cameraTransform.localRotation *= xRotation;
    }
}
