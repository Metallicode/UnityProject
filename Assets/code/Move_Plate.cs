using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Plate : MonoBehaviour
{
    [SerializeField] float Movment_Speed= 0.02f;
    float plateXoffset;
    Vector3 screenbonds;

    private void Start()
    {
        screenbonds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z))*-1;
        plateXoffset = screenbonds.x-((transform.Find("Collerctor_Plate").transform.localScale.x)/2);

        Debug.Log(screenbonds);
        Debug.Log(plateXoffset);

    }

    void Update()
    {

        var movment = Input.GetAxis("Horizontal") * Movment_Speed;
        movment = Mathf.Clamp(transform.position.x+ movment, -plateXoffset, plateXoffset);

        transform.position = new Vector3(movment, transform.position.y, 0);
    }
}
