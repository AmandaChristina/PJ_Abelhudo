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
            Mathf.Clamp(targetToFollow.position.x, -27.967f, 27.967f),
            Mathf.Clamp(targetToFollow.position.y, -16.27f, 59.37f),
            transform.position.z);
    }
}
