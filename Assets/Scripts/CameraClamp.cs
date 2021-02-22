using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;
    void Update()
    {
        transform.position = new Vector3(      
            Mathf.Clamp(targetToFollow.position.x, -22.5f, 22.5f),
            Mathf.Clamp(targetToFollow.position.y, -5f, 5f),
            transform.position.z);
    }
}
