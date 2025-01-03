using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonidos : MonoBehaviour
{
    public AudioSource ChoqueRaqueta;
    public AudioSource ChoquePared;
    public AudioSource ChoquePunto;

    private void OnCollisionEnter2D(Collision2D collisionator)
    {
        if (collisionator.gameObject.name == "Jugador 1" || collisionator.gameObject.name == "Jugador 2")
        {
            ChoqueRaqueta.Play();
        }
        else if(collisionator.gameObject.name == "Pared arriba" || collisionator.gameObject.name == "Pared abajo")
        {
            ChoquePared.Play();
        }
        else { ChoquePunto.Play(); }
    }



}
