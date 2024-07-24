using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Capsule : Shape
{
	private int edges;

	public Capsule(string shapeName, Color shapeColor) : base(shapeName, shapeColor)
	{
	}

	public int Edges { get; private set; }
}
