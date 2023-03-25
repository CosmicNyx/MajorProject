using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
