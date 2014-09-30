using UnityEngine;
using System.Collections;

public class noseRotation : MonoBehaviour {
	
	private Transform target;
	private Transform front;
	
	private float counter;
	
	public float speed;
	
	void Update () {
		if (target) {
			
			Vector3 raycastDirection = target.position - transform.position;
			Ray ray = new Ray(transform.position, raycastDirection);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.tag == "Enemy"){
					transform.LookAt (target);
					transform.Translate (Vector3.forward * 0 * Time.deltaTime);
					
				} 
			}
		}
	}
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			target = other.transform;
		}
	}
	
}
