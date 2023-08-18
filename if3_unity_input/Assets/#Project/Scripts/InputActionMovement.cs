using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

//Workflow 2 Embedded Actions
public class InputActionMovement : MonoBehaviour
{
    public InputAction move;

    public float speed;
    public void OnEnable() {
        move.Enable();
    }

    // public void OnDisable() {
    //     move.Disable();
    // }
    // Start is called before the first frame update
    void Start()
    {
        move.performed += ctx => {OnMove(ctx);};
    }

    // Update is called once per frame
    public void Update()
    {
        float moveAmount = move.ReadValue<float>();
        Debug.Log(moveAmount);

        transform.Translate(moveAmount * transform.right * speed * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context) {
        Debug.Log("MOVING !!!");
    }
}
