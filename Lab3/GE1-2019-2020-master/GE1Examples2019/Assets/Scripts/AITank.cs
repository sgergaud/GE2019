using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITank : MonoBehaviour
{
    public int numWaypoints = 5;
    public float radius = 10;
    List<Vector3> wayPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDrawGizmos()
    {
        float gap = (Mathf.PI * 2.0f) / (float) numWaypoints;
        for(int i = 0; i < numWaypoints; i ++)
        {
            Vector3 pos = new Vector3(
                Mathf.Sin(gap * i) * radius
                , 0
                , Mathf.Cos(gap * i) * radius
                );
            pos = transform.TransformPoint(pos);
            Gizmos.DrawWireSphere(pos, 2);
        }
    }

    float speed = 5.0f;
    int current = 0;

    // Update is called once per frame
    void Update()
    {
       // transform.position = Vector3.MoveTowards();
       if (Vector3.Distance(transform.position, wayPoints[current])<1.0f)
        {
            current = (current + 1) % wayPoints.Count;
        }
        transform.LookAt(wayPoints[current]);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
