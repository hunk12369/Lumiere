using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController: MonoBehaviour
{
    public PlayerScirpt playerScript;
    public int lives;
    public int parts;


    void Start()
    {
        lives = playerScript.lives;
        parts = 3;
    }

    // Update is called once per frame
    void Update()
    {
        lives = playerScript.lives;
    }
}
