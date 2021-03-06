using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyes : MonoBehaviour
{
    public GameObject Enemy;
    private float _spawnTime = 2;
    private int _spawnPosition = 1;
    private int _spawnCoordinateX;
    private float _runningTime;

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if(_runningTime >= _spawnTime)
        {
            switch (_spawnPosition)
            {
                case (1):
                    _spawnCoordinateX = -5;
                    _spawnPosition = 2;
                    break;
                case (2):
                    _spawnCoordinateX = 1;
                    _spawnPosition = 3;
                    break;
                case (3):
                    _spawnCoordinateX = 7;
                    _spawnPosition = 1;
                    break;
            }

            GameObject newObject = Instantiate(Enemy, new Vector3(_spawnCoordinateX, 0, 0), Quaternion.identity);
            _runningTime = 0;          
        }       
    }
}
