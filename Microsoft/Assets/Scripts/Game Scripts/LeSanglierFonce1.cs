using UnityEngine;
using System.Collections;

public class LeSanglierFonce1 : MonoBehaviour {
    public Transform[] patrolPoints;
    public float moveSpeed;
    private int currentPoint;

    void Start()
    {
        currentPoint = 0;
    }

    void Update()
    {
       
        if (transform.position.x == patrolPoints[currentPoint].position.x)
        {
            currentPoint++;
            this.transform.localScale = Vector3.Scale(this.transform.localScale, new Vector3(-1, 1, 1));
        }
        if (currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
        }
        Vector3 direction = new Vector3(patrolPoints[currentPoint].position.x, this.transform.position.y, this.transform.position.z);
        transform.position = Vector2.MoveTowards(transform.position, direction, moveSpeed * Time.deltaTime);
    }
}
