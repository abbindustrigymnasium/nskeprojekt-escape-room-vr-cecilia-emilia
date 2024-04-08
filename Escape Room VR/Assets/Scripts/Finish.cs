using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;

    private AudioSource audioSource;
    public AudioClip buttonDown;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void GoBackToMenu()
    {
        PlayAudioClip(buttonDown);
        sceneTransitionManager.GoToScene(0);
    }

    public void QuitApplication()
    {
        PlayAudioClip(buttonDown);
        Application.Quit();
    }

    public void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
