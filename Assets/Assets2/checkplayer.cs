using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkplayer : MonoBehaviour
{


    public static Vector3 lastcheck = new Vector3(-4.868291f, -1.174484f, 0f);
    private void Awake()
    {
        transform.position = lastcheck;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D others)
    {
        if(others.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Debug.Log(lastcheck);
    }
    void Update()
    {
        
    }
}

