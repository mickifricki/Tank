﻿using UnityEngine;
using System.Collections;

public class KinematicArrive : MonoBehaviour {

	public float min_distance = 0.1f;
	public float time_to_target = 0.25f;
	Vector3 vec;

	Move move;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}

	// Update is called once per frame
	void Update () 
	{
		// TODO 8: calculate the distance. If we are in min_distance radius, we stop moving
		// Otherwise devide the result by time_to_target (0.25 feels good)
		// Then call move.SetMovementVelocity()
		vec = move.target.transform.position - transform.position;
		if (vec.magnitude <= min_distance) 
		{
			move.SetMovementVelocity (Vector3.zero);
		} 
		else 
		{
			move.SetMovementVelocity (vec/time_to_target);
		}
	}

	void OnDrawGizmosSelected() 
	{
		// Display the explosion radius when selected
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(transform.position, min_distance);
	}
}
