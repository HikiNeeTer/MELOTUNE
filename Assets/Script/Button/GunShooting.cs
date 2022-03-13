using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

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
        GameObject nbullet = Instantiate(bullet, transform.position, Quaternion.identity);
        nbullet.GetComponent<BulletMovement>().SetTarget(target);
    }
}
