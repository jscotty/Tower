using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class myScript : MonoBehaviour {

	private Dictionary<string, string> name = new Dictionary<string, string>();
	public string dictionary;

	void Start () {
		name.Add ("Ramses", "Ramses Di Perna is 18 jaar jong");
		name.Add ("Richard", "Richard Ram is 27 jaar jong");
		name.Add ("Boy", "Boy Voesten is 17 jaar jong");
		name.Add ("Justin", "Justin Bieshaar is 18 jaar jong");
		name.Add ("Rocky", "Rocky Tempelaar is 21 jaar jong");

		//print (name[dictionary]);

	}
}
