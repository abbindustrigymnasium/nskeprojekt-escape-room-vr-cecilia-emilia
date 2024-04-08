using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeInteractableToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;

    private XRPokeInteractor _xrPokeInteractor;

    // Start is called before the first frame update
    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
            //GetComponent<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    void SetPokeAttachPoint()
    {
        if (PokeAttachPoint == null) { Debug.Log("Poke attach point is null"); return; }

        if (_xrPokeInteractor == null) { Debug.Log("XR poke interactor is null"); return; }

        _xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}
