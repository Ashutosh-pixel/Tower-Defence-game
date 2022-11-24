using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Transform target;
    [SerializeField] GameObject weapon_Top;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Enemy_Move>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        weapon_Top.transform.LookAt(target);
    }
}
