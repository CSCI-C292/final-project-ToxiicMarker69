using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    private float movementSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxisRaw("Vertical");

            //update the vertical position
            transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, 0);

            //output to log the position change
            Debug.Log(transform.position);  
    }
}
