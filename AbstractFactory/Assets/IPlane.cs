﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlane
{
	void spawnItem();
}



public class OneWingGlider: MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("1WingGlider", typeof(GameObject))) as GameObject;
	}
}
public class TwoWingGlider : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("2WingGlider", typeof(GameObject))) as GameObject;
	}
}
public class ThreeWingGlider : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("3WingGlider", typeof(GameObject))) as GameObject;
	}
}
public class FourWingGlider : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("4WingGlider", typeof(GameObject))) as GameObject;
	}
}

public class OneWingOneEnginePlane : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("1Wing1EngineAircraft", typeof(GameObject))) as GameObject;
	}
}
public class TwoWingOneEnginePlane : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("2Wing1EngineAircraft", typeof(GameObject))) as GameObject;
	}
}
public class OneWingTwoEnginePlane : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("1Wing2EngineAircraft", typeof(GameObject))) as GameObject;
	}
}
public class TwoWingTwoEnginePlane : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("2Wing2EngineAircraft", typeof(GameObject))) as GameObject;
	}
}

public class OneWingRocket : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("1WingRocket", typeof(GameObject))) as GameObject;
	}
}
public class TwoWingRocket : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("2WingRocket", typeof(GameObject))) as GameObject;
	}
}
public class ThreeWingRocket: MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("3WingRocket", typeof(GameObject))) as GameObject;
	}
}
public class FourWingRocket : MonoBehaviour, IPlane
{
	GameObject product;
	public void spawnItem()
	{
		product = Instantiate(Resources.Load("4WingRocket", typeof(GameObject))) as GameObject;
	}
}