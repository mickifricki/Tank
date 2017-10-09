using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour {

	public float max_angle = 0.5f;
	Vector3 rand_vec;
	Vector3 vec;
	Move move;
	public float targetTime = 1.0f;
	public Vector3 direccio_movement;

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
		targetTime -= Time.deltaTime;
		direccio_movement = move.mov_velocity;
		if (targetTime < 0.0f)
		{
			float angle = Mathf.Atan2 (RandomBinominal(), RandomBinominal()) * Mathf.Rad2Deg;
			rand_vec = new Vector3 (Mathf.Cos(angle),0.0f,Mathf.Sin(angle));
			vec = Vector3.Lerp (move.mov_velocity,rand_vec,max_angle);
			targetTime = 1.0f;
		}
		move.mov_velocity = move.max_mov_velocity * vec;
	}
}
