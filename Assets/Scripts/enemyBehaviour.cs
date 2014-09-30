using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour {

	public static float life = 300f;

	private void Update()
	{
		if (life <= 0) {
			//Destroy(gameObject);
			print("dood");
		}
	}
}
