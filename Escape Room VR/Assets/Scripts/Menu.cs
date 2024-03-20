using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayClick() {
        Thread.Sleep(2000);
        SceneManager.LoadScene(1);
        Debug.Log("Funktionen körs!");
    }
}
