using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControlPuntaje : MonoBehaviour
{
    private int puntajeJugador1 = 0 ;
    private int puntajeJugador2 = 0 ;

    public GameObject textoPuntaje1;
    public GameObject textoPuntaje2;

    public int metaParaGanar;

    public Text etiquetaJugadorGanador;
 

    // Update is called once per frame
    void Update()
    {
        if (this.puntajeJugador1 >= metaParaGanar || this.puntajeJugador2 >= metaParaGanar )
        {
            if (this.puntajeJugador1 == 3)
            {
                GameData.ganador = 1;
            }
            else
            {
                GameData.ganador = 2;
            }

            SceneManager.LoadScene("JuegoTerminado");
        }
        
    }

    private void FixedUpdate()
    {
        Text etiquetaPuntaje1 = this.textoPuntaje1.GetComponent<Text>();
        etiquetaPuntaje1.text = this.puntajeJugador1.ToString();

        Text etiquetaPuntaje2 = this.textoPuntaje2.GetComponent<Text>();
        etiquetaPuntaje2.text = this.puntajeJugador2.ToString();

    }

    public void GolJugador1()
    {
        this.puntajeJugador1++;
        print("gol1");
    }

    public void GolJugador2()
    {
        this.puntajeJugador2++;
        print("gol1");
    }


}
