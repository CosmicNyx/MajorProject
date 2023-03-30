using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFlicker : MonoBehaviour
{
    public Material flickeringMaterial;
    public float flickerSpeed = 1f;
    public float minBottomLine = 0.4f;
    public float maxBottomLine = 0.6f;

    void Update()
    {
        float noise = Mathf.PerlinNoise(Time.time * flickerSpeed, 0.0f);
        float bottomLine = Mathf.Lerp(minBottomLine, maxBottomLine, noise);
        flickeringMaterial.SetFloat("_BottomLine", bottomLine);
    }
}
