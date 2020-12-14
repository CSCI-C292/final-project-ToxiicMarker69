using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish3 : MonoBehaviour
{
    GameObject playerObject;
    GameObject Hook;
    [SerializeField] float _speed = 6f;
    // Start is called before the first frame update
    //static int _enemyCount = 0;
    void Start()
    {
        this.playerObject = GameObject.Find("Fish3");
        Hook = GameObject.Find("Hook");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3 (Time.deltaTime * _speed, 0, 0);
        if (gameObject.transform.position.x <= -20f){
            Destroy(gameObject);
        }
    
    }
    
    void Attachfish3()
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
            Debug.Log("Attaching Fish");
            if (Hook.GetComponent<HookMovement>().Attached == false)
            {
                Attachfish3();
                Hook.GetComponent<HookMovement>().Attached = true;
            }

        }
    }
    
}
