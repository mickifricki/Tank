using UnityEngine;
using System.Collections;

public class KinematicFlee : MonoBehaviour {

	Move move;
	Vector3 vec;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
	}

	// Update is called once per frame
	void Update () 
	{
		// TODO 6: To create flee just switch the direction to go
		vec = transform.position - move.target.transform.position;
		move.mov_velocity = move.max_mov_velocity * vec;
	}
}
