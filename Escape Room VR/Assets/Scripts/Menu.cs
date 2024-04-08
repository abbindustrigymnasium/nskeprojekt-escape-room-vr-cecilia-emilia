using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.VisualScripting.Member;

public class Menu : MonoBehaviour
{
    public List<GameObject> canvasList;
    public int canvasCount;
    public SceneTransitionManager sceneTransitionManager;

    private AudioSource audioSource;
    public AudioClip buttonDown;


    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
           canvasCount = 0;
          if (canvasList.Count > 0) { 
            canvasList[canvasCount].SetActive(true);
            }
    }

    public void OnNextClick()
    {
        if (canvasCount < canvasList.Count-1) {
            canvasList[canvasCount].SetActive(false);
            canvasCount++;
            canvasList[canvasCount].SetActive(true);
        }
        else
        {
            OnPlayClick();
        }
        Debug.Log(canvasCount);
        PlayAudioClip(buttonDown);
    }
    public void OnBackClick()
    {
        if (canvasCount > 0){ 
            canvasList[canvasCount].SetActive(false);
            canvasCount--;
            canvasList[canvasCount].SetActive(true);
        }

        Debug.Log(canvasCount);
        PlayAudioClip(buttonDown);
    }

    public void OnPlayClick() {
        // Ladda scenen med index 1 högre än nuvarande
        sceneTransitionManager.GoToScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Funktionen körs!");
        PlayAudioClip(buttonDown);
    }
    public void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
