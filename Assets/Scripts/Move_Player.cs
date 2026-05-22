using UnityEngine;
using UnityEngine.InputSystem;
public class Move_Player : MonoBehaviour
{
    Rigidbody2D physicsPlayer;
    float speedPlayer = 15f;
    InputAction inputMovement;
    
    private void OnEnable()
    {
        inputMovement.Enable();
    }
    private void OnDisable()
    {
        inputMovement.Disable();
    }
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }
}
    