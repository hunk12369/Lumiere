using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCounterSprite : MonoBehaviour
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
            ChangeSprite(gameController.parts);

    }
    void ChangeSprite(int laser)
    {
        spriteRenderer.sprite = spriteArray[laser];
    }
}
