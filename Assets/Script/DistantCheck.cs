using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistantCheck : MonoBehaviour
{
    private Transform disToButton;

    [HideInInspector] public float distance;
    [HideInInspector] public GameObject buttonReference;

    void Update()
    {
        // While Note trigger with Button
        if (buttonReference != null)
        {
            distance = Mathf.Abs(disToButton.transform.position.x - transform.position.x);
        }
        // If note didn't trigger with button yet
        else if(GetComponent<NoteObject>().buttonReference != null)
        {
            buttonReference= GetComponent<NoteObject>().buttonReference;
            disToButton = buttonReference.GetComponent<Transform>();
        }
    }
}
