using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma_1 : MonoBehaviour
{
    public Transform objetivo;//que los sigue
    public float speed;//la velocidad la cual lo perseguira
    public bool debePerseguir; //si o no
    public float distancia; //que tan lejos estamos del enemigo

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(debePerseguir==true)
        {
            transform.position = Vector2.MoveTowards(transform.position, objetivo.position, speed);//(posicion actual, a donde te diriges, distancia que se movera) 
        }
        
    }
}
