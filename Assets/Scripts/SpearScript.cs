using UnityEngine;
using System.Collections;

public class SpearScript : MonoBehaviour {

	public float speedX;
	public float speedY;
	private bool fly = false;
	private float rand;

	// Use this for initialization
	void Start () {
	
		rand = Random.Range(5.58f,-5.63f);	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= rand){
			fly = true;
		}
			
		if(fly){
			transform.Translate(Vector3.up * Time.deltaTime * speedY);	
		}
		else{
			transform.Translate(Vector3.left * Time.deltaTime * speedX);	
		}
		if(transform.position.x < -10.26){
			Destroy(gameObject);
		}	
		if(transform.position.y > 8.04){
			Destroy(gameObject);
		}
	}
}
