using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [ExecuteInEditMode] so that it only works in edit mode
[ExecuteInEditMode]
public class ColorPlayer : MonoBehaviour
{
    public Material stripeMat;
    [HideInInspector] public string color;
    [HideInInspector] public int colorIndex = 0;
    private string previousColor;

    // Update is called once per frame,thanks to color's value assigned by the ColorEditor script, change the color of the material assigned to this script
    void Update()
    {
        if (!(previousColor == color))
        {
            switch (color)
            {
                case "Black":
                    stripeMat.SetColor("_Color1", Color.black);
                    break;
                case "White":
                    stripeMat.SetColor("_Color1", Color.white);
                    break;
                case "Grey":
                    stripeMat.SetColor("_Color1", Color.grey);
                    break;
                case "Magenta":
                    stripeMat.SetColor("_Color1", Color.magenta);
                    break;
                default:
                    stripeMat.SetColor("_Color1", Color.yellow);
                    break;
            }
            previousColor = color;
        }
    }
}
