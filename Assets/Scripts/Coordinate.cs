using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class Coordinate : MonoBehaviour
{
    TextMeshPro textMeshPro;
    Vector2 position;

    void Awake()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        CoordinateRename();
        
    }


    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            CoordinateRename();
        }
    }

    private void CoordinateRename()
    {
        position.x = transform.parent.position.x;
        position.y = transform.parent.position.z;
        textMeshPro.text = position.x + "," + position.y;
        transform.parent.name = textMeshPro.text.ToString();
    }
}
