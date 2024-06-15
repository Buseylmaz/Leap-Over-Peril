using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerManager : MonoBehaviour
{
    [Header("Obstacles Prefabs Array")]
    [SerializeField] GameObject[] obstaclePrefabs;

    [Space]

    [Header("Points")]
    [SerializeField] float xPoint ;
    [SerializeField] float yPoint ;
    [SerializeField] float zPoint ;

    [Space]

    [Header("Spawner Time")]
    [SerializeField] float startDelay;
    [SerializeField] float repeatRate;

    private void Start()
    {
        InvokeRepeating("ObstacleSpawner", startDelay, repeatRate);
    }

    void ObstacleSpawner()
    {
        int index = Random.Range(0, obstaclePrefabs.Length);

        Vector3 spawnerLocation = new Vector3(xPoint, yPoint, zPoint);

        Instantiate(obstaclePrefabs[index], spawnerLocation, obstaclePrefabs[index].transform.rotation);

        
    }
}
