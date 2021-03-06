﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Move : MonoBehaviour
{

    float Movement_Size = 0.015f;
    [SerializeField] float Speed = 0.01f;

    void Start()
    {
        Debug.Log($"{this} Starts to move!");
    }

    
    void Update()
    {
        transform.position += transform.right * (Mathf.Sin(Time.time* Speed) * Movement_Size);
    }
}
