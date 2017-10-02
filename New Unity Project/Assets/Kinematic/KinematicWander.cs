﻿using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour {

	public float max_angle = 0.5f;
	Vector3 rand_vec;
	Vector3 vec;
	Move move;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}

	// number [-1,1] values around 0 more likely
	float RandomBinominal()
	{
		return Random.value * Random.value;
	}
	
	// Update is called once per frame
	void Update () 
	{
		// TODO 9: Generate a velocity vector in a random rotation (use RandomBinominal) and some attenuation factor
		float Random = RandomBinominal();
		rand_vec = new Vector3 (Mathf.Cos(Random),0.0f,Mathf.Sin(Random));
		vec = Vector3.Lerp (move.transform.position,rand_vec,max_angle);
		move.mov_velocity = move.max_mov_velocity * vec;
	}
}
