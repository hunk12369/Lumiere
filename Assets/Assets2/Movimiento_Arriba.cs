using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Arriba : MonoBehaviour
{
    public float speed; //creacion de un valor
    public bool esArriba;
    // public bool esArriba;
    public float contadorT; //este sera utilizado que vaya de uno en uno
    public float tiempoParaCambiar = 4f; //inicia en ese valor

    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        contadorT = tiempoParaCambiar;
    }

    // Update is called once per frame
    void Update()
    {
        if (esArriba == true)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (esArriba == false)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
        }
        contadorT -= Time.deltaTime; //va disminuyendo el tiempo en decreciente

        if (contadorT <= 0)
        {
            contadorT = tiempoParaCambiar;
            esArriba = !esArriba; //va a ir cambiando de derecha a izquierda y viceversa
        }
    }
}
