using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioClip buttonDown;
    public AudioClip buttonUp;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayAudioClip()
    {
        source.PlayOneShot(source.clip);
    }

}
