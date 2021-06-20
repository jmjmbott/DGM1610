using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public enum ColorChoice
    {
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple
    }
    public ColorChoice theColor;
    public bool isPrimary;

    void Update()
    {
        switch (theColor)
        {
            case ColorChoice.Red:
                isPrimary = true;
                break;
            case ColorChoice.Yellow:
                isPrimary = true;
                break;
            case ColorChoice.Blue:
                isPrimary = true;
                break;
            default:
                isPrimary = false;
                break;

        }
    }
}