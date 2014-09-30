using UnityEngine;
using System.Collections;

public class noseBehaviour : MonoBehaviour {

	public GameObject bullet;
	private Transform target;

	public GameObject nose;
	
	private float counter;
	
	public float speed;
	
	void Update () {
		if (target) {
			
			Vector3 raycastDirection = target.position - nose.transform.position;
			Ray ray = new Ray(transform.position, raycastDirection);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.tag == "Enemy"){
					nose.transform.LookAt (target);
					nose.transform.Translate (Vector3.forward * 1 * Time.deltaTime);
					Shoot();
				} 
			}else {

			}
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			target = other.transform;
		}
	}
	
	void Shoot(){
		counter += 1;
		//print (counter);
		if(counter >= 10f){
			Instantiate(bullet, bullet.transform.position, nose.transform.rotation);
			counter = 0f;
			
		}
	}
}
