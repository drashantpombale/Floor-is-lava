using UnityEngine;
using UnityEngine.InputSystem;

public class RightClickMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody UnitBody;
    private PlayerInputControls movementInputAction;
    private void Start()
    {
        movementInputAction = new PlayerInputControls();
        movementInputAction.Movement.Move.performed += MovePlayer;
    }
    private void MovePlayer(InputAction.CallbackContext obj)
    {
        Vector2 mouseClickScreenLocation = obj.ReadValue<Vector2>();
        UnitBody.MovePosition(mouseClickScreenLocation);
    }

    private void Update()
    {
       
    }
}
