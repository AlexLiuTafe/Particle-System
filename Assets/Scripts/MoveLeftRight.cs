using UnityEngine;
using System.Collections;

public class MoveLeftRight : MonoBehaviour
{

	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 2.0f;
	private Vector3 startPos;

	void Start()
	{
		startPos = transform.position;
	}

	void Update()
	{
		Vector3 v = startPos;
		v.x += delta * Mathf.Sin(Time.time * speed);//Sin for left and right
		v.z += delta * Mathf.Cos(Time.time * speed);//Cos for rotation 
		transform.position = v;
	}
}
