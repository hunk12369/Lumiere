using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySprite : MonoBehaviour
{
    public GameController gameController;
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.lives == 4)
        {
            ChangeSprite(0);
        }
        else if (gameController.lives == 3)
        {
            ChangeSprite(1);
        } else if (gameController.lives == 2)
        {
            ChangeSprite(2);
        } else
        {
            ChangeSprite(3);
        }


    }
    void ChangeSprite(int lives)
    {
        spriteRenderer.sprite = spriteArray[lives];
    }
}
