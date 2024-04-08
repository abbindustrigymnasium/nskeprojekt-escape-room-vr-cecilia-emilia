using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;


public class ExitDoor : MonoBehaviour
{
    public bool doorHandleHovered = false;
    [SerializeField] private GameObject doorLock;
    public SceneTransitionManager sceneTransitionManager;

    public void OnDoorHandleGrab()
    {
        // Loadar scenen med scenindex +1 fr�n den nuvarande om handtaget har hovrats f�rst
        if (doorHandleHovered)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            sceneTransitionManager.GoToScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    public void DoorHandleHover()
    {
        // N�r man hovrar �ver handtaget kollar spelet om man har satt i nyckeln, om ja s� ska man kunna ta tag i handtaget p� d�rren.
        if (doorLock.gameObject.GetComponent<ExitLock>().keyInserted)
        {
            doorHandleHovered = true;
        }
        
    }
}
