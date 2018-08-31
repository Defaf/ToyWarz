using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.UI;

[RequireComponent(typeof(NavMeshAgent))]
public class chase : MonoBehaviour {

	public Transform player;// the target 
	public Transform head; 
	static Animator anim;
	//NavMeshAgent nav; 
	bool track = false ; 
	public Slider healthbar;
	Vector3 eDist ; 
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		//nav = GetComponent<NavMeshAgent> ();
		anim.SetBool ("isDead",false);
		//eDist = nav.destination; 
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		if (healthbar.value == 0) return;  

		//rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
		Vector3 direction = player.position - this.transform.position ;
		direction.y = 0;
		//float angle = Vector3.Angle(direction,this.transform.forward);
		float angle = Vector3.Angle(direction,head.up);
		float checkDist = Vector3.Distance (player.position, this.transform.position); 
		if(checkDist < 10 &&  ( angle < 100) || track)
		{
			//eDist = player.position; 
			//nav.destination = eDist; 
			track = true;
			//nav.SetDestination (player.transform.position);
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction), 2.0f);

			anim.SetBool("isIdle",false);

			if(direction.magnitude > 5)//direction.magnitude > 5
			{
				//this.transform.Translate(0,0,0.05f);
				anim.SetBool("isWalking",true);
				anim.SetBool("isAttacking",false);
			}

			//else if(checkDist == 4.0f)
			//{
			anim.SetBool("isAttacking",true);
			anim.SetBool("isWalking",false);
			//}

		}
		else 
		{
			anim.SetBool("isIdle", true);
			anim.SetBool("isWalking", false);
			anim.SetBool("isAttacking", false);
			track = false;
		}



	}
}
