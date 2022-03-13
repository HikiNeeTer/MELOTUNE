using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    [SerializeField] private Transform target;

    private float turnSpeed;

    void Start()
    {
        turnSpeed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = 90.0f;
        Vector2 dir = target.position - transform.position;
        dir.Normalize();

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(Vector3.forward * (angle + offset)), turnSpeed * Time.deltaTime);
    }
}
