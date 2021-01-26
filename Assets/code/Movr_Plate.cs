using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movr_Plate : MonoBehaviour
{
    [SerializeField] float Movment_Speed= 0.02f;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Movment_Speed, Input.GetAxis("Vertical") * Movment_Speed, 0);
    }
}
