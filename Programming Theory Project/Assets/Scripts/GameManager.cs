using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	[SerializeField] List<GameObject> shapes;
	Shape cube;
	Shape sphere;
	Shape capsule;

	[SerializeField] TextMeshProUGUI shapeDetailsText;

	void Awake()
	{
		// upcast
		cube = shapes[0].GetComponent<Cube>();
		sphere = shapes[1].GetComponent<Sphere>();
		capsule = shapes[2].GetComponent<Capsule>();
	}

	public void CubeButton()
	{
		shapeDetailsText.text = cube.DisplayText();
	}
	public void SphereButton()
	{
		shapeDetailsText.text = sphere.DisplayText();
	}
	public void CapsuleButton()
	{
		shapeDetailsText.text = capsule.DisplayText();
	}
}
