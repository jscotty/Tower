using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyChecker : MonoBehaviour {

	private Dictionary<string, Checker> enemy = new Dictionary<string, Checker> ();

	public Transform enemy1;
	public Transform enemy2;
	public Transform enemy3;

	
	public Transform bullet;
	public Transform nose;
	private int counter;

	public string enemyColor;
	public int enemyPower;

	private Transform target;
	
	void Start()
	{
		Checker en1 = new Checker (enemy1, 100);
		Checker en2 = new Checker (enemy2, 300);
		Checker en3 = new Checker (enemy3, 200);

		enemy.Add ("red", en1);
		enemy.Add ("blue", en2);
		enemy.Add ("green", en3);


		Checker temp = null;

		//print (enemy ["green"].name);


	}
	void Update()
	{
		print (target);
	}

	void OnTriggerEnter(Collider other){
		if (enemy[enemyColor].power == enemyPower ) {
			target = other.transform;
		}
		//else counter = 0;
	}

	void Shoot(){
		//print ("shiet");
		counter += 1;
		//print (counter);
		if (counter == 1) {
			Instantiate (bullet, bullet.transform.position, bullet.transform.rotation);
				} else if (counter >= 1) {
					counter = 0;
				}
			
	}
}
