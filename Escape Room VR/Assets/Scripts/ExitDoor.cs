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
        // Loadar scenen med scenindex +1 från den nuvarande om handtaget har hovrats först
        if (doorHandleHovered)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            sceneTransitionManager.GoToScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    public void DoorHandleHover()
    {
        // När man hovrar över handtaget kollar spelet om man har satt i nyckeln, om ja så ska man kunna ta tag i handtaget på dörren.
        if (doorLock.gameObject.GetComponent<ExitLock>().keyInserted)
        {
            doorHandleHovered = true;
        }
        
    }
}
