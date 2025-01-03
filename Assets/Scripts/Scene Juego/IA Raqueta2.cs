using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IARaqueta2 : MonoBehaviour
{
    public float velocidad;
    public GameObject pelota;



    private void FixedUpdate()
    {
        if (Mathf.Abs(this.gameObject.transform.position.y - pelota.gameObject.transform.position.y) > 50)
        {
            if(this.transform.position.y < pelota.transform.position.y) 
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * velocidad;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1)* velocidad;
            }
        }

        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }



        
    }
}
