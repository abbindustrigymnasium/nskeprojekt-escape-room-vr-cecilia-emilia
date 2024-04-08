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

    private AudioSource audioSource;
    public AudioClip insertedKeyAudio;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " nuddade nyckelhålet");

        // Om det som rör collidern = nyckeln så ska nyckeln fasta i hålet och variabeln keyInserted bli sann
        if (other.gameObject == key)
        {
            other.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            other.gameObject.GetComponent<Rigidbody>().useGravity = false;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Collider>().enabled = false;
            other.gameObject.transform.transform.SetPositionAndRotation(keyhole.position, keyhole.rotation);
            keyInserted = true;

            PlayAudioClip(insertedKeyAudio);

            Invoke("EnableDoorHandle", 0.5f);
        }
    }

    private void EnableDoorHandle()
    {
        doorHandle.gameObject.GetComponent<XRGrabInteractable>().enabled = true;
        Debug.Log("Dörren är upplåst!");
    }

    public void PlayAudioClip(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
