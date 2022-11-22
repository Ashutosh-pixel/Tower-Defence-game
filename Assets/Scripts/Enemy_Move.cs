using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    [SerializeField] List<waypoints> path = new List<waypoints>();
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Path());
    }

    IEnumerator Path()
    {
        foreach (waypoints waypoints in path)
        {
            transform.LookAt(waypoints.transform.position);
            Vector3 startpoint = transform.position;
            Vector3 endpoint = waypoints.transform.position;
            float delta = 0;
            while (delta < 1f)
            {
                delta += Time.deltaTime*speed;
                transform.position = Vector3.Lerp(startpoint,endpoint,delta);
                yield return null;
            }
        }

    }
}
