using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float speed; //creacion de un valor
    public bool esDerecha;
   // public bool esArriba;
    public float contadorT; //este sera utilizado que vaya de uno en uno
    public float tiempoParaCambiar = 4f; //inicia en ese valor

    // Start is called before the first frame update
    void Start()
    {
        contadorT = tiempoParaCambiar;
    }

    // Update is called once per frame
    void Update()
    {
        if(esDerecha == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (esDerecha == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
        }
/*
        if (esArriba == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
         //   transform.localScale = new Vector3(-1, 1, 1);
        }
        if (esArriba == false)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
           // transform.localScale = new Vector3(1, 1, 1);
        }
*/
        contadorT -= Time.deltaTime; //va disminuyendo el tiempo en decreciente

        if(contadorT <= 0)
        {
            contadorT = tiempoParaCambiar;
            esDerecha = !esDerecha; //va a ir cambiando de derecha a izquierda y viceversa
        }
    }

}
