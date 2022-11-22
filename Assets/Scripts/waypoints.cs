using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{
    [SerializeField] bool Tile;

    void OnMouseDown(){
        if(Tile == true){
            Debug.Log(transform.name.ToString());
        }
        
    }
}
