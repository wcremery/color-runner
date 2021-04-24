using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHelp : MonoBehaviour
{
    public ColorReference colorType;
    public ColorType.ColorList current;
    public Image background;
    public Image image;
    [Header("Sprites")]
    public Sprite rectangle;
    public Sprite triangle;
    public Sprite circle;
    public Sprite beam;
    public Sprite star;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        if(current!= colorType.Value)
        {
            current = colorType.Value;
            UpdateColor();
        }

    }
    private void UpdateColor()
    {
        
        Sprite change;
        background.color = ColorType.getColor(current);
        switch (current)
        {
            case ColorType.ColorList.Red:
                change = rectangle;
                break;
            case ColorType.ColorList.Green:
                change = triangle;
                break;
            case ColorType.ColorList.Blue:
                change = star;
                break;
            case ColorType.ColorList.Yellow:
                change = circle;
                break;
            case ColorType.ColorList.Null:
                change = beam;
                break;
            default:
                change = beam;
                break;
        }
        image.sprite = change;
    }
}
