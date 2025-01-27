using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("1. Mensaje de Información");
        Debug.LogWarning("1. Mensaje de Aviso");
        // Debug.LogError("1. Mensaje de Error");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("2. Mensaje de Información");
        Debug.LogWarning("2. Mensaje de Aviso");
        // Debug.LogError("2. Mensaje de Error");
    }
}
