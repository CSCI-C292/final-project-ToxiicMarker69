using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaWeedSpawner : MonoBehaviour
{
    float _yMin;
    float _yMax;
    float _xSpawn;
    float _randI;
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] GameObject _gameOverText;
    bool _isGameOver = false;
    
    void Start()
    {
        
        _yMin = Camera.main.ViewportToWorldPoint(new Vector3(0,.4f,0)).y;
        _yMax = Camera.main.ViewportToWorldPoint(new Vector3(0,-1,0)).y;
        _xSpawn = Camera.main.ViewportToWorldPoint(new Vector3(1.5f, 0,0)).x;


        InvokeRepeating("SpawnEnemy", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && _isGameOver) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void SpawnEnemy() 
    {
        float randY = Random.Range( _yMin, _yMax);
        Instantiate(_enemyPrefab, new Vector3(_xSpawn,randY, -.5f) , Quaternion.identity);
    }

    public void InitiateGameOver() 
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);
    }
}
