using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light flickeringLight;
    public float minIntensity = 0.5f;
    public float maxIntensity = 1f;
    public float minRange = 5f;
    public float maxRange = 10f;

    void Update()
    {
        flickeringLight.intensity = Random.Range(minIntensity, maxIntensity);
        flickeringLight.range = Random.Range(minRange, maxRange);
    }
}
