using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    public int currentHealth, maxHealth;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; ; //para empezar con todo la vida    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//obtener daño de cualquier cosa, la funcion
    public void DealDamage()
    {
        currentHealth--; //va reduciendo las vidas

        if(currentHealth <= 0)
        {
            gameObject.SetActive(false); //para morir
        }

    }
}
