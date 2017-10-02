using UnityEngine;
using System.Collections;

public class KinematicSeek : MonoBehaviour {

	Move move;
	Vector3 vec;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}

	// Update is called once per frame
	void Update () 
	{
		// TODO 5: Set movement velocity to max speed in the direction of the target
		vec = move.target.transform.position - transform.position;
		move.mov_velocity = move.max_mov_velocity * vec;
	}
}