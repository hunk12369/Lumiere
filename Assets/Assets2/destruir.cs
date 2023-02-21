using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    public GameObject fantasma;
    public float timer;
    bool disparar;
    public void OnMouseDown()
    {
  
            Destroy(fantasma);
        
        //Debug.Log("HolaMundo");
    }
    void Update()
    {
        
             
    }
}
