using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    public Light discoLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        discoLight.color = Color.HSVToRGB(Random.Range(0, 1), Random.value, Random.value);
    }
}
