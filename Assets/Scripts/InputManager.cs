using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour{

    private Vector2 moveDirection = Vector2.zero;
    private bool jumpPressed = false;
    private bool interactPressed = false;
    private bool submitPressed = false;

    private static InputManager instance;

    private void Awake(){
        if(instance !=null){
            Debug.LogError("Found more than one Input Manager in the scene");
        }

        instance = this;
    }
    public static InputManager GetInstance(){
        return instance;
    }
    public void MovePressed (InputAction.CallbackContext context){
        if(context.performed){
            moveDirection = context.ReadValue<Vector2>();
            } else if(context.canceled){
                moveDirection = context.ReadValue<Vector2>();
        }
    }
    public void JumpPressed(InputAction.CallbackContext context){
        if(context.performed){
            jumpPressed = true;
        } else if(context.canceled){
            jumpPressed = false;
        }
    }
    public void InteractedButttonPressed(InputAction.CallbackContext context){
        if(context.performed){
            interactPressed = true;
        } else if(context.canceled){
            interactPressed = false;
        }
    }
}
