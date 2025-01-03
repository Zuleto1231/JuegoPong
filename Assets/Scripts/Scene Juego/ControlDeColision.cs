using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeColision : MonoBehaviour
{
    public Mover mover;//Creamos una instancia de la clase pelota para utilizar los metodos que ya usamos
    public ControlPuntaje controlPuntaje;

    void ReboteConRaqueta(Collision2D collisionator)
    {
        Vector3 posicionPelota = this.transform.position;//Todos los objetos tienen transform y de ahi sacamos su posicion que es un vector de 3 valores de la pelota
        Vector3 posicionRaqueta = collisionator.transform.position;//Todos los objetos tienen transform y de ahi sacamos su posicion que es un vector de 3 valores de la raqueta
        float alturaRaqueta = collisionator.collider.bounds.size.y;//Altura de la raqueda bound nos devuelve las dimensiones del colisionador y size una de ellas en este caso necesitamos saber que tan grande es la raqueta lo hacemos con y

        float direccionX;
        if (collisionator.gameObject.name == "Jugador 1")
        {
            direccionX = 1;
        }
        else
        {
            direccionX = -1;
        }

        float direccionY = (posicionPelota.y - posicionRaqueta.y) / alturaRaqueta;

        this.mover.AumentarVelocidadPorGolpes();
        this.mover.MoverPelota(new Vector2(direccionX, direccionY));



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Jugador 1" || collision.gameObject.name == "Jugador 2" )
        {
            this.ReboteConRaqueta(collision);

        }
        else if (collision.gameObject.name == "Pared derecha")
        {
            controlPuntaje.GolJugador1();
            StartCoroutine(this.mover.IniciarPelota(false));
        }

        else if (collision.gameObject.name == "Pared izquierda")
        {
            controlPuntaje.GolJugador2();
            StartCoroutine(this.mover.IniciarPelota(true));
        }
    }


}
