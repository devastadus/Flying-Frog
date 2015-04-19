using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = Vector2.MoveTowards(transform.position,target,Time.deltaTime *speed);

	}
}
