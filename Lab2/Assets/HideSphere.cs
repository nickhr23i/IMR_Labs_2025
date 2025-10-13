using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HideSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    private XRDirectInteractor interactor;
    void Start()
    {
        interactor = GetComponent<XRDirectInteractor>();
        if (interactor != null)
        {
            interactor.selectEntered.AddListener(OnGrab);
            interactor.selectExited.AddListener(OnRelease);
        }

    }

    private void OnRelease(SelectExitEventArgs arg0)
    {
        if (sphere != null)
        {
            sphere.SetActive(true);
        }
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        if (sphere != null)
        {
            sphere.SetActive(false);
        }
    }

}
