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
            CollisionHandler(5,0);
        }
        else if (collision.transform.gameObject.tag == "Fail")
        {
            CollisionHandler(-5,1);
        }
    }


    void CollisionHandler(int currentscore, int soundindex)
    {
        score.Set_Score(currentscore);
        soundmanager.PlaySound(soundindex);
        Destroy(gameObject);
    }

}
