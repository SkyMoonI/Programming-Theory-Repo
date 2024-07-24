using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
	void Start()
	{
		ShapeName = "Capsule";
		ShapeColor = Color.red;
		GetComponent<MeshRenderer>().material.color = ShapeColor;
	}


}
