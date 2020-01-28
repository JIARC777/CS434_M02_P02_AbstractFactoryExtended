using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AbstractFactory: MonoBehaviour
{
	public GliderFactory gliderFactory;
	public AircraftFactory aircraftFactory;
	public RocketFactory rocketFactory;
	
	public void SpawnItem(Requirements reqs)
	{
		if (reqs.rocket)
		{
			rocketFactory.ManufactureRocket(reqs);
		}
		else if (reqs.numberOfEngines > 0)
		{
			aircraftFactory.ManufacturePoweredAircraft(reqs);
			
		} else
		{
			gliderFactory.ManufactureGlider(reqs);
		}
	}
}
