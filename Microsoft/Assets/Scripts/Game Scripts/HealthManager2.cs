using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager2 : MonoBehaviour {

	public int maxLife;
	public static int currentLife;
	public Sprite[] heartContainer;
	public Image HeartUi;
	private LevelManager lM;
	//bool damaged = false;
	public bool isDead = false;
	private GameObject player;


	void Awake ()
	{
		currentLife = maxLife;
		lM = GetComponent<LevelManager> ();
		isDead = false;
		FullHealth ();

	}
		
	// Update is called once per frame
	void Update () 
	{
		HeartUi.sprite = heartContainer[currentLife];

		if (currentLife > maxLife)
			FullHealth ();

		if (currentLife <= 0 && !isDead) 
		{
			currentLife = 0;
			isDead = true;
			Debug.Log ("I'm dead man");
			//lM.RespawnPlayer();

		}

		if(currentLife == heartContainer.Length)
		{
			currentLife = 0;
		}
	}

	public static void HurtPlayer(int damageToGive)
	{
		//damaged = true;
		currentLife -= damageToGive;
	}

	public void FullHealth()
	{
		currentLife = maxLife;
	}
}
