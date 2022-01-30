using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCheck : MonoBehaviour
{
    private Queue<GameObject> NoteList;

    void Start()
    {
        // Initialize List
        NoteList = new Queue<GameObject>();
    }

    void Update()
    {
        
    }

    // Add note to NoteList
    public void addNote(GameObject note)
    {
        NoteList.Enqueue(note);
    }

    // Delete note that are on the front
    public void deleteNote()
    {
        NoteList.Dequeue();
    }

    // For checking what note is on the front
    public GameObject isCurrentNote()
    {
        return NoteList.Peek();
    }
}
