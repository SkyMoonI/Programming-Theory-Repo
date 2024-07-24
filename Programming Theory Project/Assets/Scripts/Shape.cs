using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
	protected String shapeName;
	protected Color shapeColor;

	public Shape(String shapeName, Color shapeColor)
	{
		this.shapeName = shapeName;
		this.shapeColor = shapeColor;
	}
	protected void DisplayText()
	{
		Debug.Log(shapeName + " is " + shapeColor);
	}

	public virtual void DisplayColor()
	{
		Debug.Log(shapeName + " is " + shapeColor);
	}
}
