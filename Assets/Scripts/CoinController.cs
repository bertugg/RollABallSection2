using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(12 * Time.deltaTime, 6 * Time.deltaTime, -9.23f * Time.deltaTime);
    }
}