using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private float shakeDuration;
    private float shakeAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0.0f)
        {
            Vector3 shakeLocation = Random.insideUnitSphere * shakeAmount;
            transform.localPosition = new Vector3(shakeLocation.x, shakeLocation.y, -10.0f);
            shakeDuration -= Time.deltaTime;
        }
    }

    public void ShakeCam(float shakeDuration, float shakeAmount)
    {
        this.shakeDuration = shakeDuration;
        this.shakeAmount = shakeAmount;
    }
}
