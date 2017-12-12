using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {


	private TrailRenderer tr;

	void Start()
	{
		tr = GetComponent<TrailRenderer>();
	}

	void Update()
	{
		if (Input.GetMouseButtonUp (0)) {
			tr.time = 5.0f; //how many seconds it takes to start deleting the trail
		}
			
	}

}