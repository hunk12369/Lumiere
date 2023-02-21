using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANim_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", true);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyUp(KeyCode.D))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", false);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyDown(KeyCode.A))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", true);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyUp(KeyCode.A))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", false);//presionando la tecla mediante teclado
        }
/*
        if (Input.GetKeyDown(KeyCode.W))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", true);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyUp(KeyCode.W))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", false);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyDown(KeyCode.S))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", true);//presionando la tecla mediante teclado
        }
        if (Input.GetKeyUp(KeyCode.S))//identifica la tecla para iniciar instruccion
        {
            anim.SetBool("Run", false);//presionando la tecla mediante teclado
        }*/
    }
}
