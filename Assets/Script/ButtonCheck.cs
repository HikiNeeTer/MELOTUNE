using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    [SerializeField] private Queue<NoteObject> NoteList;
    [SerializeField] private NoteObject noteObj;

    void Start()
    {
        // Initialize List
        NoteList = new Queue<NoteObject>();
    }

    void Update()
    {
        noteObj = currentNote();
        // If currentNote is null then return
        if (currentNote() == null)
        {
            return;
        }

        // If User Hit Note then Destroy Object
        if (Input.GetKeyDown(noteObj.keyToPress))
        {
            DistantCheck dc = noteObj.GetComponent<DistantCheck>();
            //Debug.Log(dc.distance);
            if (dc.distance <= 0.5)
            {
                Debug.Log("perfect");
            }
            else if (dc.distance <= 1)
            {
                Debug.Log("Great");
            }
            else if (dc.distance <= 2)
            {
                Debug.Log("Good");
            }
            deleteNote(noteObj);
            Destroy(noteObj.gameObject);
        }
    }

    // Add note to NoteList
    public void addNote(NoteObject note)
    {
        NoteList.Enqueue(note);
    }

    // Delete note that are on the front
    public void deleteNote(NoteObject noteObj)
    {
        // If NoteList is empty -> return
        if (NoteList.Count == 0)
        {
            return;
        }

        // If Peek of NoteList is noteObj then delete from List
        if (NoteList.Peek() == noteObj)
        {
            NoteList.Dequeue();
        }
    }

    // For checking what note is on the front
    public NoteObject currentNote()
    {
        // If NoteList is empty -> return null
        if (NoteList.Count == 0)
        {
            return null;
        }

        return NoteList.Peek();
    }
}
