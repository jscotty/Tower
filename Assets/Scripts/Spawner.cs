using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public float timer;
	public GameObject[] enemys;

	private void Update()
	{
		timer += 1f;
		if (timer == 300) {
			timer = Random.Range(0,240);
			int enemyIndex = Random.Range(0, enemys.Length);
			Instantiate(enemys[enemyIndex],this.transform.position, this.transform.rotation);
		}
	}
}
