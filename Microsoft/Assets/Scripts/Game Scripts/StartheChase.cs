using UnityEngine;
using System.Collections;

public class StartheChase : MonoBehaviour {

    EnemyMovement Patrouille;
    LeSanglierFonce Chase;
    LeSanglierFonce1 Chase2;
    public float CurrentAmount;
    public float speed;
    public bool InZone;




    void Start() {
        Patrouille = FindObjectOfType<EnemyMovement>();
        Chase = FindObjectOfType<LeSanglierFonce>();
        Chase2 = FindObjectOfType<LeSanglierFonce1>();

        CurrentAmount = 3;

    }


    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            InZone = true;
            Patrouille.enabled = false;
        }
            

    }


    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {

            InZone = false;
          
        }
    }

    void Update()
    {
        if(InZone == true)
        {

            CurrentAmount -= speed * Time.deltaTime;

            if (Patrouille.Where == false)
            {
                if (CurrentAmount <= 0)
                {
                    Chase.enabled = false;
                    Chase2.enabled = true;
                }
            }


            if (Patrouille.Where == true)
            {

                if (CurrentAmount <= 0)
                {
                    Chase.enabled = true;
                    Chase2.enabled = false;
                }
            }
        }

        if (!InZone)
        {
            Patrouille.enabled = true;
            Chase.enabled = false;
            Chase2.enabled = false;
            CurrentAmount = 3;
        }
    }

}
