using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

// Link the editor to ColorPlayer
[CustomEditor(typeof(ColorPlayer))]
public class ColorEditor : Editor
{
    string[] m_Colors = new string[]{
        "Black",
        "White",
        "Grey",
        "Magenta"
    };

// Use the GUI to show array of string, writen in m_Colors and defining the string choosed by the user to color
    public override void OnInspectorGUI()
    {
        ColorPlayer myTarget = (ColorPlayer)target;
        DrawDefaultInspector();

        myTarget.colorIndex = EditorGUILayout.Popup("Color", myTarget.colorIndex, m_Colors);

        myTarget.color = m_Colors[myTarget.colorIndex];
    }
}