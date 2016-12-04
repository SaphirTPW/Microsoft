using UnityEngine;
using System.Collections;

public class HurtPlayerOnContact : MonoBehaviour {

	public int damageToGive;
	private HealthManager healthmanager;


	// Use this for initialization
	void Start () 
	{
		healthmanager = FindObjectOfType<HealthManager> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
		HealthManager.HurtPlayer (damageToGive);
		
		
	}
}
