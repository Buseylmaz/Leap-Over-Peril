using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] float obstacleMoveSpeed;

    private void Update()
    {
        Move();
        ObstacleDestroy();
    }

    void Move()
    {
        transform.Translate(Vector3.left * obstacleMoveSpeed * Time.deltaTime);
    }

    void ObstacleDestroy()
    {
        Destroy(gameObject, 15f);
    }
}
