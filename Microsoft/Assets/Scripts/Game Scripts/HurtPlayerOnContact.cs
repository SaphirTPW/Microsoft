using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {

    public int damageToGive;
	private HealthManager2 healthmanager;


	// Use this for initialization
	void Start () 
	{
		healthmanager = GetComponent<HealthManager2> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player")
			HealthManager2.HurtPlayer(damageToGive);
		
	}
}
