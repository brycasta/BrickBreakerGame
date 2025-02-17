using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


//Bryan Castaneda
public class PaddleMove : MonoBehaviour
{
    // Variables
    protected Vector3 moveDirection = Vector3.zero;
    [SerializeField, Range(1, 20)] protected float moveSpeed = 1.0f;
    //[SerializeField, Range(10, 29)] protected float maxSpeed = 25.0f;

    // Methods
    private void Update()
    {
        MovePaddle();
    }

    // Takes Input from Action
    public void MoveInput(InputAction.CallbackContext aContext)
    {
        Vector2 av2 = aContext.ReadValue<Vector2>();

        moveDirection.x = av2.x;
        //aMoveDirection.z = av2.y;
    }

    // Moves the Paddle

    public void MovePaddle()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    // Accessors
}