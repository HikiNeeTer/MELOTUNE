using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public KeyCode keyToPress;
    
    [HideInInspector] public GameObject buttonReference;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If trigger then note can Press
        if (collision.CompareTag("Button"))
        {
            // When note trigger with button get buttonReference
            buttonReference = collision.gameObject;
            // Add current note to NoteList which are in buttonReference
            buttonReference.GetComponent<ButtonCheck>().addNote(this);
        }

    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        // If trigger(exit) then note cannot Press
        if (collision.CompareTag("Button"))
        {
            if (collision.gameObject != null)
            {
                buttonReference.GetComponent<ButtonCheck>().deleteNote(this);
            }
        }
    }
}
