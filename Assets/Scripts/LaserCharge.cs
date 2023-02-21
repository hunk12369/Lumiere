using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCharge : MonoBehaviour
{
    public GameController gameController;
    public SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per fra

    public void OnMouseDown()
    {
        GetComponent<Animator>().Play("LaserChanger");
    }
}
