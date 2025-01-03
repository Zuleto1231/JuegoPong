using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float VelocidadInicial;
    public float VelocidadExtra;
    public float VelocidadExtraMaxima;
    int contadorGolpes;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.IniciarPelota());

    }

    public IEnumerator IniciarPelota(bool jugador1Comienza = true)
    {
        this.PosicionarPelota(jugador1Comienza);
        this.contadorGolpes= 0;

        yield return new WaitForSeconds(1);

        if (jugador1Comienza)
        {
            this.MoverPelota(new Vector2(-1, 0));
        }
        else
        {
            this.MoverPelota(new Vector2(1, 0));
        }





    }

    public void MoverPelota(Vector2 VectorDeMovimiento)

    {
        Rigidbody2D pelota = this.gameObject.GetComponent<Rigidbody2D>();
        VectorDeMovimiento = VectorDeMovimiento.normalized;
        float velocidad = this.VelocidadInicial + this.contadorGolpes * this.VelocidadExtra;

        pelota.velocity = VectorDeMovimiento * velocidad;
       
    }
    public void AumentarVelocidadPorGolpes()
    {
        if (this.contadorGolpes * this.VelocidadExtra <= this.VelocidadExtraMaxima)
        {
            this.contadorGolpes++;
        }
        
    }
    void PosicionarPelota(bool comienzaJugador1)
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        if (comienzaJugador1)
        {
            this.transform.localPosition = new Vector3(-100, 0, 0);

        }
        else
        {
            this.transform.localPosition = new Vector3(100, 0, 0);
        }

    }



   
}
