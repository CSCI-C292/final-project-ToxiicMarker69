using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish3Spawner : MonoBehaviour
{
    float _yMin;
    float _yMax;
    float _xSpawn;
    float _randI;
    [SerializeField] GameObject _enemyPrefab;
    
    void Start()
    {
        
        _yMin = Camera.main.ViewportToWorldPoint(new Vector3(0,-.5f,0)).y;
        _yMax = Camera.main.ViewportToWorldPoint(new Vector3(0,-1,0)).y;
        _xSpawn = Camera.main.ViewportToWorldPoint(new Vector3(1.5f, 0,0)).x;


        InvokeRepeating("SpawnEnemy", 0, 18f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy() {
        float randY = Random.Range( _yMin, _yMax);
        Instantiate(_enemyPrefab, new Vector3(_xSpawn,randY, -.5f) , Quaternion.identity);
    }
}