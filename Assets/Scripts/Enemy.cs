using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MovingDistance = 20;
    private float StartPos;

    void Start()
    {
        StartPos = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, StartPos + Mathf.PingPong(Time.time * 2f, MovingDistance), transform.position.z);
    }
}
