using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    [SerializeField] Transform target = null;
    [SerializeField][Range(20, 90)] float pitch = 45;
    [SerializeField][Range(2, 8)] float distance = 5;
    [SerializeField][Range(0.1f, 2.0f)] float sensitivy = 1;

    float yaw = 0;
    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * sensitivy;   
        
        Quaternion qyaw = Quaternion.AngleAxis(yaw, Vector3.up);
        Quaternion qpitch = Quaternion.AngleAxis(pitch, Vector3.right);
        Quaternion rotation = qyaw * qpitch;

        transform.position = target.transform.position + (rotation * Vector3.back * 5);
        transform.rotation = rotation;
    }
}
