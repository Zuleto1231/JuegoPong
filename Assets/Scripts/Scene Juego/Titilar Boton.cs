using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitilarBoton : MonoBehaviour
{
    public Text texto;
    private float timer = 0f;
    public float blinkRate = 0.5f; // Tiempo en segundos para alternar la visibilidad

    void Update()
    {
        // Incrementar el temporizador en cada frame
        timer += Time.deltaTime;

        // Si el temporizador supera el tiempo de parpadeo, alternar la visibilidad del texto
        if (timer >= blinkRate)
        {
            texto.enabled = !texto.enabled;
            timer = 0f; // Reiniciar el temporizador
        }
    }
}
