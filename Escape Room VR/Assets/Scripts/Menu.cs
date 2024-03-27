using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public List<GameObject> canvasList;
    public int canvasCount;
    public void Start()
    {
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
    }
    public void OnBackClick()
    {
        if (canvasCount > 0){ 
            canvasList[canvasCount].SetActive(false);
            canvasCount--;
            canvasList[canvasCount].SetActive(true);
        }

        Debug.Log(canvasCount);
    }

    public void OnPlayClick() {
        SceneManager.LoadScene(1);
        Debug.Log("Funktionen k�rs!");
    }
}
