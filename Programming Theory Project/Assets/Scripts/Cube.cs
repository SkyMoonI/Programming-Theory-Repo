using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
	private int edges;
	public int Edges { get { return edges; } set { edges = value; } }

	void Start()
	{
		ShapeName = "Cube";
		ShapeColor = Color.green;
		Edges = 6;
		GetComponent<MeshRenderer>().material.color = ShapeColor;
	}

	override public string DisplayText()
	{
		string temp = base.DisplayText();
		return temp + "\n" + "Edges: " + Edges;
	}

}
