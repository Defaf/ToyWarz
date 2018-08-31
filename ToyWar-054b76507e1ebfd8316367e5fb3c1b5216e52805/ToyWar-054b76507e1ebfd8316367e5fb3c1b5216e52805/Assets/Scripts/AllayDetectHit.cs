using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllayDetectHit : MonoBehaviour {

	public Slider healthbar;
	Animator anim;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag != "BeakHit" ) return;
		healthbar.value -= 5;

		if (other.gameObject.tag != "waveHit" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "CatPunch" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "CatEye" ) return ; 
		healthbar.value -= 15;

		if (other.gameObject.tag != "EBearKick" ) return ; 
		healthbar.value -= 5;

		if (other.gameObject.tag != "EBearPunch" ) return ; 
		healthbar.value -= 10;

		if (other.gameObject.tag != "EBearCotton" ) return ; 
		healthbar.value -= 15;


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
