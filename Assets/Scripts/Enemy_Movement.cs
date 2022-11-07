using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{

    [SerializeField] List<Transform> path = new List<Transform>();
    [SerializeField] [Range(0,5)]float speed = 1f;

    private void Start()
    {
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        foreach (Transform item in path)
        {
            Vector3 startposition = transform.position;
            float elapsedtime = 0;
            Vector3 endposition = item.transform.position;
            transform.LookAt(endposition);

            while (elapsedtime < 1f)
            {
                elapsedtime += Time.deltaTime*speed;
                transform.position = Vector3.Lerp(startposition, endposition, elapsedtime);
                yield return null;
            }
        }
    }


}
