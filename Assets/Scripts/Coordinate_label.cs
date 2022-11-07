using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class Coordinate_label : MonoBehaviour
{
    TextMeshPro textMeshPro;
    //Vector2 position = new Vector2();


    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        Coordinate();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            Coordinate();
        }
    }

    private void Coordinate()
    {
        //position.x = transform.parent.position.x;
        //position.y = transform.parent.position.z;
        textMeshPro.text = transform.parent.position.x + "," + transform.parent.position.z;
        transform.parent.name = textMeshPro.text;
    }
}
