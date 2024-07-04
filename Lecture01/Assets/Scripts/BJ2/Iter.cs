using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iter : MonoBehaviour
{
    // 구구단 출력
    [SerializeField] private int n;

    private void Awake()
    {
        PrintResult();
    }

    private void PrintResult()
    {
        for (int i = 1; i < 10; i++)
        {
            Debug.Log($"{n} * {i} = {n * i}");
        }
    }
}
