using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    [SerializeField] Score score;
    SoundManager soundmanager;

    void Start()
    {
        score = GameObject.FindObjectOfType<Score>();
        soundmanager = FindObjectOfType<SoundManager>();
    

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.gameObject.tag);

        if (collision.transform.gameObject.tag == "Plate")
        {
            score.Set_Score(5);
            soundmanager.PlaySound(0);
            Destroy(gameObject);

        }
        else if (collision.transform.gameObject.tag == "Fail")
        {
            score.Set_Score(-5);
            soundmanager.PlaySound(1);
            Destroy(gameObject);
        }


      
    }
}
