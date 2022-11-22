using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{
    [SerializeField] bool tile;
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool istowerplaced = false;
    

    void OnMouseDown(){
        if(tile == true && istowerplaced == false){
            Instantiate(towerPrefab,transform.position,Quaternion.identity);
            istowerplaced = true;
        }
        
    }
}
