using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    Rigidbody rigidBody;
    [SerializeField] float playerSpeed = 5;
   // [SerializeField] float rotateSpeed = 90;
    
    

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // Quaternion rotation = transform.rotation;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

       // transform.rotation = new Quaternion(transform.rotation.x * horizontalInput, transform.rotation.x * horizontalInput, transform.rotation.z * verticalInput, 90f);
        rigidBody.velocity = new Vector3(horizontalInput * playerSpeed, rigidBody.velocity.y, verticalInput * playerSpeed);

      //  float rotateAmount = Input.GetAxis("Rotation") * rotateSpeed * Time.deltaTime;
        //Quaternion rotateDelta = Quaternion.Euler(0, rotateAmount, 0);
       // rotation *= rotateDelta;         // Set the new rotation of the cube
        //transform.rotation = rotation;
    }
}
