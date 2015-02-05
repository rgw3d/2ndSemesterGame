using UnityEngine;
using System.Collections;

public class movement3D : MonoBehaviour {

	//Variables
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F; 
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
    public float rotationSpeed = 70; 
    private float yRotation; 
    private float xRotation;
    public Camera camera;

	CharacterController controller;

	void Start() {
		controller = GetComponent<CharacterController>();
        yRotation = transform.localEulerAngles.x;
        xRotation = transform.localEulerAngles.y;
	}
	
	void Update() {
		// is the controller on the ground?

        
		if (controller.isGrounded) {
            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
			//Jumping
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
			
		}
        else {
            //controller.Move(Vector3.forward * Input.GetAxis("Vertical") * -1 * Time.deltaTime * speed / 3);
            //controller.Move(Vector3.right * Input.GetAxis("Horizontal") * -1 * Time.deltaTime * speed / 3);
        }

        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);

        yRotation -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        yRotation = Mathf.Clamp(yRotation, -60, 60);
        xRotation += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        xRotation = xRotation % 360;
        camera.transform.localEulerAngles = new Vector3(yRotation,0,0);
        transform.transform.localEulerAngles = new Vector3(0,xRotation,0);

		
	}
}
