using UnityEngine;

public class InputController : MonoBehaviour
{
    private InputSystem_Actions _inputSystem;
    public Rigidbody _rigidbody;
    public Transform playerInputSpace = default;
    public int speed = 7;
    private Vector2 rotation = new();

    void Start()
    {
        _inputSystem = new();
        _inputSystem.Enable();

        Cursor.lockState = CursorLockMode.Locked;
    }

    void HandleRotation()
    {
        var lookInputState = _inputSystem.Player.Look.ReadValue<Vector2>();
        rotation += lookInputState;
        rotation.x = rotation.x % 360;
        rotation.y = rotation.y % 360;
    }

    void HandleInput()
    {
    }

    void Update()
    {
        HandleRotation();
        HandleInput();
    }

    void FixedUpdate()
    {
        var movementInputState = _inputSystem.Player.Move.ReadValue<Vector2>();
        movementInputState.Normalize();
        var forward = playerInputSpace.forward;
        var right = playerInputSpace.right;
        _rigidbody.AddForce(forward * movementInputState.y * speed);
        _rigidbody.AddForce(right * movementInputState.x * speed);
    }
}
