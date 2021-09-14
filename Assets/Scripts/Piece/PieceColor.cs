using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above

        //spriteRenderer.sprite = ???;
        var randomNumber = Random.Range(0, 7);

        if(randomNumber == 0)
        {
            spriteRenderer.sprite = blueColor;
        }
        else if(randomNumber == 1)
        {
            spriteRenderer.sprite = redColor;
        }
        else if(randomNumber == 2)
        {
            spriteRenderer.sprite = greenColor;
        }
        else if(randomNumber == 3)
        {
            spriteRenderer.sprite = purpleColor;
        }
        else if(randomNumber == 4)
        {
            spriteRenderer.sprite = goldColor;
        }
        else if(randomNumber == 5)
        {
            spriteRenderer.sprite = greyColor;
        }
        else
        {
            spriteRenderer.sprite = brownColor;
        }

    }
}
