using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public Transform[] patrolPoints;
    public float moveSpeed;
    private int currentPoint;
    public bool Where;

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
            Where = true;//right
        }
        if (currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;
            Where = false;//left
        }
        Vector3 direction = new Vector3(patrolPoints[currentPoint].position.x, this.transform.position.y, this.transform.position.z);
        transform.position = Vector2.MoveTowards(transform.position, direction, moveSpeed * Time.deltaTime);
    }
    /*public float moveSpeed;
    public Transform[] PatrolPoints;
    private int CurrentPoint;
    public GameObject Sanglier;


	void Start () {
        transform.position = PatrolPoints[0].position;
        CurrentPoint = 0;
	}
	
	
	void Update () {


        if (CurrentPoint >= PatrolPoints.Length)
        {
            CurrentPoint = 0;
        }

        if (transform.position == PatrolPoints[CurrentPoint].position)
        {
            CurrentPoint++;
            Sanglier.transform.localScale += new Vector2(0f, 0f);

        }

        transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[CurrentPoint].position, moveSpeed * Time.deltaTime);
	
	}*/
}
