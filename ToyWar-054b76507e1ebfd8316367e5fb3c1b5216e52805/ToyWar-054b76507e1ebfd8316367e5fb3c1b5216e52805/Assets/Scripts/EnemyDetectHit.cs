using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDetectHit : MonoBehaviour {

	public Slider healthbar;
	Animator anim;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag != "BunnyKick" ) return;
		healthbar.value -= 5;

		if (other.gameObject.tag != "BunnyPunch" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "BunnyEar" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "DogKick" ) return ; 
		healthbar.value -= 5;

		if (other.gameObject.tag != "DogPunch" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "DogAttack" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "Angel_Cotton" ) return ; 
		healthbar.value -= 20;


		if (healthbar.value == 0) {

			anim.SetBool ("isDead", true);
			Destroy (gameObject, 5.0f);
		}
	}
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
	}
}
