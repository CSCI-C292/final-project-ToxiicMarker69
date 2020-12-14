using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaWeed : MonoBehaviour
{
    GameObject playerObject;
    GameObject Hook;
    [SerializeField] float _speed = 2f;
    [SerializeField] float _rotationspeed = 50.0f;
    // Start is called before the first frame update
    //static int _enemyCount = 0;
    void Start()
    {
        this.playerObject = GameObject.Find("SeaWeed");
        Hook = GameObject.Find("Hook");  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (Time.deltaTime * _speed, 0, 0);
        transform.Rotate (0, 0, _rotationspeed * Time.deltaTime);
        if (gameObject.transform.position.x <= -20f){
            Destroy(gameObject);
        }
    
    }
    
    void Attachseaweed()
    {
        this.transform.parent = Hook.transform;
        _speed = 0;
        Debug.Log("Attached " + gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Collision Detected");
        if (collider.gameObject.name == "Hook")
        {
            Debug.Log("Attaching Sea Weed");
            if (Hook.GetComponent<HookMovement>().Attached == false)
            {
                Attachseaweed();
                Hook.GetComponent<HookMovement>().Attached = true;
            }

        }
    }
    
}
