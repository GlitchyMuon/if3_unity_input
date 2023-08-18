using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting.APIUpdating;

//Workflow 3 Actions Asset

public class ActionsAssetMovement : MonoBehaviour
{
    public InputActionAsset actions;
    private InputAction move;
    public float speed;

    void OnEnable()
    {
        actions.FindActionMap("Player").Enable();
    }

    void OnDisable()
    {
        actions.FindActionMap("Player").Disable();
    }
    void Awake() {
        move = actions.FindActionMap("Player").FindAction("move");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = move.ReadValue<float>();
        transform.Translate(moveAmount * transform.right * speed * Time.deltaTime);
    }

}