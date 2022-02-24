using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    [SerializeField]
    private float offset;

    [SerializeField]
    private NoteMovement noteSheet;

    private Vector2 startPosition;
    private float newXposition;
    private float timeCount;

    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        if (noteSheet.hasStart)
        {
            newXposition = Mathf.Repeat(timeCount * -moveSpeed, offset);
            transform.position = startPosition + Vector2.right * newXposition;
            timeCount += Time.deltaTime;
        }
    }
}
