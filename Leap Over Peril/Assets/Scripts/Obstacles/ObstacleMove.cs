using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] float obstacleMoveSpeed;

    public PlayerController playerController;

    private void Update()
    {
        Move();
        ObstacleDestroy();
    }

    void Move()
    {

        if (playerController != null && !playerController.isDead)
        {
            transform.Translate(Vector3.left * obstacleMoveSpeed * Time.deltaTime);
        }
        
    }

    void ObstacleDestroy()
    {
        Destroy(gameObject, 15f);
    }
}
