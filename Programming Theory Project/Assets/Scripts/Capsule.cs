using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Capsule : Shape
{
	void Start()
	{
		ShapeName = "Capsule";
		ShapeColor = Color.red;
		GetComponent<MeshRenderer>().material.color = ShapeColor;
	}


}
