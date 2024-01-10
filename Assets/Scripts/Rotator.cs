using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField][Range(-360, 360)] float angle;
    [SerializeField][Range(-360, 360)] float speed = 5;
    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.AngleAxis(angle * , Vector3.up);
        transform.rotation = Quaternion.AngleAxis(angle * Time.deltaTime, Vector3.up);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

    }
}
