using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABSum : MonoBehaviour
{
    private int a;
    private int b;

    private void Awake()
    {
        Debug.Log(Sum(1, 1));
        Debug.Log(Sum(20, 15));
        Debug.Log(Sum(200, 100));
        Debug.Log(Sum(2000, 1000));
    }

    private int Sum(int a, int b)
    {
        return a + b;
    }
}
