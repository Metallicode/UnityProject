using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Maker : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] float interval = 1.0f;
    float time_counter;

    // Start is called before the first frame update
    void Start()
    {
        time_counter = interval;
    }

    // Update is called once per frame
    void Update()
    {
        time_counter -= Time.deltaTime;

        if (time_counter < 0)
        {
            time_counter = interval;
            Instantiate(prefab, transform.position, Quaternion.identity);
        }


    }
}
