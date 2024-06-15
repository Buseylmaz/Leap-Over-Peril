using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] float backgroundSpeed;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * backgroundSpeed);
    }
}
