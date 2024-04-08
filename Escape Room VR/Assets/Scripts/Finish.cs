using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;
    public void GoBackToMenu()
    {
        sceneTransitionManager.GoToScene(0);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
