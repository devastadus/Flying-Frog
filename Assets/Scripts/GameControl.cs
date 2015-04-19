using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	
	public GameObject fireBall;
	public GameObject spear;
	public GameObject fireBomb;

	public float fireballSpawnTime = 3f;
	private float fireBallX = 8.32f;
	private float fireBallYHigh = 4.71f;
	private float fireBallYLow = -4.65f;

	public float spearSpawnTimeHigh;
	public float spearSpawnTimeLow;
	private float spearX = 6.25f;
	private float spearY = -4.51f;

	private float fireBombX = 7.54f;
	private float fireBombY = 4.6f;

	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnFireBall",fireballSpawnTime,fireballSpawnTime);
		InvokeRepeating("SpawnSpear",fireballSpawnTime,Random.Range(spearSpawnTimeLow,spearSpawnTimeHigh));
		InvokeRepeating("SpawnFireBomb",fireballSpawnTime,Random.Range(spearSpawnTimeLow,spearSpawnTimeHigh));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnFireBall(){
		Vector3 pos = new Vector3(fireBallX,Random.Range(fireBallYLow,fireBallYHigh),0);
		GameObject.Instantiate(fireBall,pos,Quaternion.identity);
	}

	void SpawnSpear(){
		Vector3 pos = new Vector3(spearX,spearY,0);
		GameObject.Instantiate(spear,pos,Quaternion.identity);
	}

	void SpawnFireBomb(){
		Vector3 pos = new Vector3(fireBombX,fireBombY,0);
		GameObject.Instantiate(fireBomb,pos,Quaternion.identity);

	}
}
