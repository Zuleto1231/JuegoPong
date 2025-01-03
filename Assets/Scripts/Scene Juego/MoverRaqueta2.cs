
using UnityEngine;

public class MoverRaqueta2 : MonoBehaviour
{
    public float velocidadRaqueta;


    private void FixedUpdate()
    {
        float movimientoVertical = Input.GetAxisRaw("Vertical2");

        Rigidbody2D Raqueta1 = GetComponent<Rigidbody2D>();
        Raqueta1.velocity= new Vector2 (0f, movimientoVertical) * velocidadRaqueta;


    }



}
