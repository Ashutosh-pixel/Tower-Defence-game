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
        yield return new WaitForSeconds(1);
        foreach (waypoints waypoints in path)
        {
            
            Vector3 endpoint = waypoints.transform.position;
            transform.LookAt(endpoint);
            float distance = Vector3.Distance(transform.position, endpoint);
            while (transform.position != endpoint)
            {
                transform.position = Vector3.MoveTowards(transform.position, endpoint, distance * Time.deltaTime*speed);
                yield return null;
            }
        }
    }
}
