using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arr : MonoBehaviour
{
    private int[] arr = new int[3];

    private void Awake()
    {
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        
        Count(2);
        FindMax();
        Switch();
    }

    private void Count(int target)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) count++;
        }
        Debug.Log(count);
    }

    private void FindMax()
    {
        int currentMax = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (currentMax < arr[i]) currentMax = arr[i];
        }
        Debug.Log(currentMax);
    }

    private void Switch()
    {
        // 0 ~ 9 까지 넣고 처음과 끝을 서로 스위치
        arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        int temp = arr[0];
        arr[0] = arr[arr.Length - 1];
        arr[arr.Length - 1] = temp;

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }
}
