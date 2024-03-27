using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(TextToAudioPlayer))]
public class TextToAudioPlayerEditor : Editor
{
    string textToRead = ""; // Holds the text input from the user

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector(); // Draws the default inspector

        TextToAudioPlayer script = (TextToAudioPlayer)target;

        // Text field for input
        textToRead = EditorGUILayout.TextField("Text to Read", textToRead);

        // Read Text button
        if (GUILayout.Button("Read Text"))
        {
            if (!string.IsNullOrEmpty(textToRead))
            {
                script.ReadText(textToRead);
            }
        }
    }
}
