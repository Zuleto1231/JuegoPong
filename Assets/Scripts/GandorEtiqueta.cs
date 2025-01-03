using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GandorEtiqueta : MonoBehaviour
{
    public Text tituloGanador;
    // Start is called before the first frame update
    void Start()
    {   
        if (GameData.ganador == 1)
        {
            tituloGanador.text = "Gana Manuel Papasito";
        }
        else 
        {
            tituloGanador.text = "Gana Daniela :(";
        }
        
    }

    
}
