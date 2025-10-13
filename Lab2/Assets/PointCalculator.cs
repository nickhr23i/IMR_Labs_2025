using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class PointCalculator : MonoBehaviour
{
    private GameObject target;
    public TextMeshProUGUI displayText;
    public XRDirectInteractor interactor;
    private float distance;
    private void Start()
    {
        target = GameObject.Find("Target");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (displayText != null && target != null && interactor != null)
        {
            distance = Vector3.Distance(target.transform.position,interactor.transform.position);
            distance = distance * 20;
            displayText.text = distance.ToString("F0")+" points";
            displayText.gameObject.SetActive(true);
        }
    }
}
