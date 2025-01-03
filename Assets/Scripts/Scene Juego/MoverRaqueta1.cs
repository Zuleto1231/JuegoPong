
using UnityEngine;

public class MoverRaqueta1 : MonoBehaviour
{
    public float velocidadRaqueta;


    private void FixedUpdate()
    {
        float movimientoVertical = Input.GetAxisRaw("Vertical");

        Rigidbody2D Raqueta1 = GetComponent<Rigidbody2D>();
        Raqueta1.velocity= new Vector2 (0f, movimientoVertical) * velocidadRaqueta;


    }



}
