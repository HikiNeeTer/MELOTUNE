using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Vector3 target;

    private float bulletSpeed = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Debug.Log("ERROR");
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, bulletSpeed * Time.deltaTime);
        if(Vector2.Distance(transform.position,target) < 0.1f)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetTarget(Vector3 target)
    {
        this.target = target;
    }
}
