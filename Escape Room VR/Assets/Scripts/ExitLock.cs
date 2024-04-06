using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ExitLock : MonoBehaviour
{
    [SerializeField] private GameObject doorHandle;
    [SerializeField] private GameObject key;
    [SerializeField] private Transform keyhole;
    public bool keyInserted = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " nuddade nyckelh�let");

        // Om det som r�r collidern = nyckeln s� ska nyckeln fasta i h�let och variabeln keyInserted bli sann
        if (other.gameObject == key)
        {
            other.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Collider>().enabled = false;
            other.gameObject.transform.position = keyhole.position;
            keyInserted = true;
            doorHandle.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }

}
