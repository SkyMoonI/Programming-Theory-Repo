using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
	void Start()
	{
		ShapeName = "Sphere";
		ShapeColor = Color.blue;
		GetComponent<MeshRenderer>().material.color = ShapeColor;
	}


}
