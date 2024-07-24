using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
	private int edges;
	// ENCAPSULATION
	public int Edges { get { return edges; } set { edges = value; } }

	void Start()
	{
		ShapeName = "Cube";
		ShapeColor = Color.green;
		Edges = 6;
		GetComponent<MeshRenderer>().material.color = ShapeColor;
	}

	// POLYMORPHISM
	override public string DisplayText()
	{
		string temp = base.DisplayText();
		return temp + "\n" + "Edges: " + Edges;
	}

}
