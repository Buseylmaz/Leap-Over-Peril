using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] float backgroundSpeed;

    public PlayerController playerController;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        if (playerController.isDead == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * backgroundSpeed);
        }
        
    }
}
