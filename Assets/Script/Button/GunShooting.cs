using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shootingPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Vector3 target)
    {
        GameObject nbullet = Instantiate(bullet, shootingPosition.GetComponent<Transform>().position, transform.rotation);
        nbullet.GetComponent<BulletMovement>().SetTarget(target);
    }
}
