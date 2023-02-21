using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaSpawner : MonoBehaviour
    
{
    float timer;
    public GameObject fantasmaPrefab;
    public Transform player;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            timer = 0;
            Quaternion rotation = new Quaternion();
            float x = Random.Range(-4f, 4f)+1;
            float y = Random.Range(-4f, 4f)+1;
            Vector3 position = new Vector3(player.transform.position.x+x, player.transform.position.y+y, player.transform.position.z+1);
            Instantiate(fantasmaPrefab,position, rotation);
           // DestroyImmediate(fantasmaPrefab,true);
        }
        
    }
    
}
