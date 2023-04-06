using UnityEngine;

public class TriggerMaterialController : MonoBehaviour
{
    public Material targetMaterial;
    public float inputIncrement = 1.5f;

    private bool playerEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerEntered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerEntered = false;
        }
    }

    private void Update()
    {
        if (playerEntered)
        {
            float currentInput = targetMaterial.GetFloat("_SurfaceInput");
            float newInput = currentInput + inputIncrement * Time.deltaTime;
            targetMaterial.SetFloat("_SurfaceInput", newInput);
        }
    }
}
