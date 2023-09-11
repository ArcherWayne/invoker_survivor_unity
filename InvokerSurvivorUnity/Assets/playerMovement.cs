using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
	private Vector3 initialPosition;
	// Start is called before the first frame update
	void Start()
	{
		transform.Rotate(new Vector3(0, 0, (float)0.1));
		gameObject.name = "Wind Runner";
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(new Vector3(0, 0, (float)0.1));
	}
}
