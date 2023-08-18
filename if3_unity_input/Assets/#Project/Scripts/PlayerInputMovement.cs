using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Workflow 4 PlayerInput Component
public class PlayerInputMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction move;
    public float speed;

    void Awake() {
        playerInput = GetComponent<PlayerInput>();
        move = playerInput.actions["move"];
    }
    public void OnMove(InputAction.CallbackContext context) {
        if(context.performed) {
            Debug.Log(context.control);
        }
            
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
