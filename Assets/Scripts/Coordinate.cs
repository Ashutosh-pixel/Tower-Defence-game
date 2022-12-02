using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class Coordinate : MonoBehaviour
{
    TextMeshPro textMeshPro;
    Vector2 position;
    waypoints waypoints;
    [SerializeField] bool isdebugkey;

    void Awake()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        isdebugkey = textMeshPro.enabled = false;
        waypoints = GetComponentInParent<waypoints>();
        CoordinateRename();

    }


    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            CoordinateRename();
        }


        CoordinateColor();
        DebugKey();
    }

    public void CoordinateRename()
    {
        position.x = transform.parent.position.x;
        position.y = transform.parent.position.z;
        textMeshPro.text = position.x + "," + position.y;
        transform.parent.name = textMeshPro.text.ToString();
    }

    public void CoordinateColor()
    {
        if (waypoints.placable == true)
        {
            textMeshPro.color = Color.gray;
        }
        else
        {
            textMeshPro.color = Color.white;
        }
    }

    public void DebugKey()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (isdebugkey == false)
            {
                textMeshPro.enabled = true;
                isdebugkey = true;
            }

            else
            {
                textMeshPro.enabled = false;
                isdebugkey = false;
            }
            
        }
    }
}
