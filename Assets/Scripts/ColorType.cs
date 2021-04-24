using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class ColorType
{
    //colors :
    private static Color yellowColor =  new Color(255, 255, 0);
    private static Color blueColor = new Color(0, 0, 255);
    private static Color greenColor = new Color(0, 255, 0);
    private static Color redColor = new Color(255, 0, 0);
    private static Color whiteColor = new Color(255, 255, 255);
    public enum ColorList
    {
        Null, Red, Green, Blue, Yellow
    }
    public static Color getColor(ColorList color)
    {
        Color change;
        switch (color){
              case ColorList.Red:
                change = redColor;
                break;
            case ColorList.Green:
                change = greenColor;
                break;
            case ColorList.Blue:
                change = blueColor;
                break;
            case ColorList.Yellow:
                change = yellowColor;
                break;
            case ColorList.Null:
                change = whiteColor;
                break;
            default:
                change = whiteColor;
                break;
        }
        return change;
    }
}
