using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float dirX;
    public float dirY;
    public SpriteRenderer spr;
    public Rigidbody2D rb;
    public int vida=3;
    //void awake
    
    
    void Start()
    {
        vida = 3;  
    }
    
    private void OnTriggerEnter2D(Collider2D Others)
    {
        if(Others.CompareTag("Enemigo"))
        {
            vida = vida - 1;
            Debug.Log(vida);
        }
    }
    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(dirX*speed, dirY*speed);

        //transform.position += new Vector3(dirX * speed, 0, 0);
        //otra forma de transladarse
      // transform.Translate(Vector3.right * dirX * speed);
        if (dirX > 0)
        {
            spr.flipX = false;
        }
        if (dirX < 0)
        {
            spr.flipX = true;
        }
       // transform.Translate(Vector3.up * dirY * speed);
        if (dirY > 0)
        {
            spr.flipY = false;
        }
        if (dirY < 0)
        {
            spr.flipY = true;
        }
        /*else
        {
            spr.flipX = true;
        }*/
    }
}
