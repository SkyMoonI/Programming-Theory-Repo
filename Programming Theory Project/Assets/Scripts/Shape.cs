using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
	private String shapeName;
	private Color shapeColor;
	public String ShapeName
	{
		get
		{ return shapeName; }
		set
		{ shapeName = value; }
	}
	public Color ShapeColor
	{
		get
		{ return shapeColor; }
		set
		{ shapeColor = value; }
	}


	public virtual String DisplayText()
	{
		Debug.Log(ShapeName + " Button Clicked");
		Debug.Log("Shape Name with getter: " + ShapeName);
		Debug.Log("Shape Color with getter: " + ShapeColor);

		return ShapeName + " Button Clicked\n" +
		"Shape Name with getter: " + ShapeName + "\n"
		+ "Shape Color with getter: " + ShapeColor;
	}

}
