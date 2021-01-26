using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audiosource;
    [SerializeField] AudioClip[] clips;

    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
    }

    public void PlaySound(int clipIndex)
    {
        audiosource.PlayOneShot(clips[clipIndex]);

    }
}
