using UnityEngine;
using System.Collections;

public class BulletShoot : MonoBehaviour {

	public float speed;
	public float destroyTime;
	public float damage;

	void Start(){
		Destroy (gameObject, destroyTime);
	}

	void Update () {
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			enemyBehaviour.life -= damage;

		}
	}
}
