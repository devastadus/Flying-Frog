using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {
	
	public float speed;
	private bool collide = false;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(collide){
			if(animator.GetCurrentAnimatorStateInfo(0).IsName("End State")){
				Destroy(gameObject);
			}
		}
		transform.Translate(Vector3.left * Time.deltaTime * speed);	
		if(transform.position.x < -10.26){
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		animator.SetTrigger("Explosion");
		collide = true;
	}

}
