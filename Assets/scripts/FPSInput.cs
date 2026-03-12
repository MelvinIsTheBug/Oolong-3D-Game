using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 4.0f;
    public float gravity = -9.8f;

    //create a variable that references the character controller
    private CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed; 

        //instead of moving the player using transform translate, use the character controller
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        //ensures the player doesn't move too fast
        movement = Vector3.ClampMagnitude(movement, speed);


        //apply gravity 
        movement.y = gravity;

        //since speed(technically velocity) times time equals distance
        //multiple by time.deltatime to move a certain amount within one frame
        movement *= Time.deltaTime;
        
        //transform movement from local to global coordinates
        movement = transform.TransformDirection(movement);

        //move the character controller using the Move() method
        charController.Move(movement);
        
    }
}
