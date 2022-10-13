using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject target;
    private Vector3 distance;

    void Start()
    {
        distance = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        transform.position = target.transform.position + distance;
    }
}
