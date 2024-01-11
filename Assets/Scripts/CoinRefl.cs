using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRefl : MonoBehaviour
{
    public Transform Coin;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Coin.position.x, transform.position.y, Coin.position.z);
    }
}
