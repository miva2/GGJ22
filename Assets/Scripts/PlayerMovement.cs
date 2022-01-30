using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Diagnostics;

public class PlayerMovement : MonoBehaviour
{
    public int stepDistance;
    private PlayerInput playerInput; // don't think I need this

   void OnMoveUp() // I don't know why this is not triggering
   {
       Debug.Log("Moving up!");
       transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + stepDistance);    
   }

   void OnMoveDown()
   {
       Debug.Log("Moving down!");
       transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - stepDistance);    

   }

   void OnMoveLeft()
   {
       Debug.Log("Moving left!");
       transform.position = new Vector3(transform.position.x - stepDistance, transform.position.y, transform.position.z);
   }

   void OnMoveRight()
   {
       Debug.Log("Moving right!");
       transform.position = new Vector3(transform.position.x + stepDistance, transform.position.y, transform.position.z);
   }


    void Start(){   
        //   Debug.Log(playerInput.currentActionMap);
        playerInput = GetComponent<PlayerInput>();

        Debug.Log(playerInput.currentControlScheme);
        Debug.Log(playerInput.currentActionMap);
    
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 mousePosition = Mouse.current.position.ReadValue();
        // Debug.Log(mousePosition); // ok retrieving the mouse position using new input system works

        // Debug.Log(Keyboard.current.upArrowKey.IsPressed()); // this also works
        
    }
}
