using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D others)
    {
        if(others.CompareTag("Player"))
        {
            checkplayer.lastcheck = transform.position;
        }
    }

}
