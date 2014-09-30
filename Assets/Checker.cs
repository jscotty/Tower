using UnityEngine;
using System.Collections;
using System;

public class Checker : IComparable<Checker>
{

	public Transform name;
	public int power;

	public Checker(Transform newName, int newPower)
	{
		name = newName;
		power = newPower;
	}

	public int CompareTo(Checker other)
	{
		if (other == null) {
			return 1;	
		}

		return power - other.power;
	}
}
