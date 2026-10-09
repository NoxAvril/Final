using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleVehicleController : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float turnSpeed = 80f;

    public InputActionAsset inputActions;

    InputAction moveAction;

    void OnEnable()
    {
        moveAction = inputActions.FindAction("Move");
        moveAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
    }

    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        float throttle = moveInput.y;
        transform.Translate(0f, 0f, throttle * moveSpeed * Time.deltaTime);

        if (Mathf.Abs(throttle) > 0.1f)
        {
            float turn = moveInput.x * turnSpeed * Time.deltaTime * Mathf.Sign(throttle);
            transform.Rotate(0f, turn, 0f);
        }
    }
}