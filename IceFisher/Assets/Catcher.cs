using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catcher : MonoBehaviour
{
    GameObject Hook;
    public bool _isGameOver = false;
    [SerializeField] GameObject _gameOverText;
    void Start()
    {
        Hook = GameObject.Find("Hook");
    }
    
    void Update() 
    {
        if (Input.GetButtonDown("Submit") && _isGameOver) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    //[SerializeField] GameObject _gameState;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.name != "Hook")
        {
            if(collider.gameObject.name == "SeaWeed(Clone)")
            {
                InitiateGameOver();
                Debug.Log("Caught " + collider.gameObject);
                Destroy(collider.gameObject);
            }
            
            else
            {
                Debug.Log("Caught " + collider.gameObject);
                Destroy(collider.gameObject);
            }


            if (Hook.GetComponent<HookMovement>().Attached == true)
            {
                Hook.GetComponent<HookMovement>().Attached = false;
            }
            //_gameState.Instance.IncreaseScore(10);
        }
    }
    public void InitiateGameOver() 
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);

    }
}
