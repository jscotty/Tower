using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public float speed;

	void Update () {
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}
