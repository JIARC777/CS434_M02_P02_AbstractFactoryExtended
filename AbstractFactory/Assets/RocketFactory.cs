using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFactory : MonoBehaviour
{
	GameObject product;
	public void ManufactureRocket(Requirements aircraftReqs)
	{
		switch (aircraftReqs.numberOfWings)
		{
			case 1:
				product = Instantiate(Resources.Load("1WingRocket", typeof(GameObject))) as GameObject;
				break;
			case 2:
				product = Instantiate(Resources.Load("2WingRocket", typeof(GameObject))) as GameObject;
				break;
			case 3:
				product = Instantiate(Resources.Load("3WingRocket", typeof(GameObject))) as GameObject;
				break;
			case 4:
				product = Instantiate(Resources.Load("4WingRocket", typeof(GameObject))) as GameObject;
				break;
			default:
				Debug.Log("The factory is unable to create the requested Object");
				break;
		}
	}
}
