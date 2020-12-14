using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    GameObject SurfaceCollider;
    public bool Attached = false;
    private float movementSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        SurfaceCollider = GameObject.Find("SurfaceCollider");
    }

    // Update is called once per frame
    void Update()
    {
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxisRaw("Vertical");

            //update the vertical position
            
            if (this.transform.position.y > 1.8)
            {
                if (verticalInput <= 0)
                {
                    transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, 0);
                }
                else
                {
                    
                }
            }

            else if (this.transform.position.y < -15)
            {
                if (verticalInput >= 0)
                {
                    transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, 0);
                }
                else
                {
                    
                }
            }

            else if (SurfaceCollider.GetComponent<Catcher>()._isGameOver == true)
            {
                    transform.position = transform.position + new Vector3(0, 0, 0);
            }

            else
            {
                transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, 0);
            }
            //output to log the position change
            //Debug.Log(transform.position);  
    }
}
