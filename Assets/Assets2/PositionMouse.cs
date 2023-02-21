using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMouse : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }
    void OnTriggerEnter()
    {
        if (this.CompareTag("Enemy"))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
