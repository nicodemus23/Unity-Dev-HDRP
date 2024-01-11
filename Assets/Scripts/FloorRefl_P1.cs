using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRefl_P1 : MonoBehaviour
{
    public Transform Sphere;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Sphere.position.x, transform.position.y, Sphere.position.z);
    }
}
