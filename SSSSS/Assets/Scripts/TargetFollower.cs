using UnityEngine;
using System.Collections;

public class TargetFollower : MonoBehaviour {
	public Transform target;

	private Vector3 offset;

	void Start()
	{

		offset = target.position - this.transform.position;
	}

	void Update()
	{ 
		this.transform.position = target.position - offset;
		transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	}
	
}
