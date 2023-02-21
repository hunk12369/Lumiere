using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject screen;
    public GameObject battery;
    public GameObject partCounter;
    public GameObject laserCharge;
    public GameObject lights;
    public float screenOffset;
    public float batteryOffsetX;
    public float batteryOffsetY;
    public float partOffsetX;
    public float partOffsetY;
    public float laserOffsetX;
    public float laserOffsetY;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + screenOffset, player.transform.position.y, transform.position.z);
        screen.transform.position = new Vector3(player.transform.position.x + screenOffset, player.transform.position.y, screen.transform.position.z);
        battery.transform.position = new Vector3(player.transform.position.x + batteryOffsetX, player.transform.position.y + batteryOffsetY, screen.transform.position.z);
        partCounter.transform.position = new Vector3(player.transform.position.x + partOffsetX, player.transform.position.y + partOffsetY, screen.transform.position.z);
        laserCharge.transform.position = new Vector3(player.transform.position.x + laserOffsetX, player.transform.position.y + laserOffsetY, screen.transform.position.z);
        lights.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, screen.transform.position.z);
    }
}
