using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
	[SerializeField] Animator Anim;


	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Platform")
		{
			Anim.SetTrigger("Landed");
		}
		if (collision.gameObject.tag == "Rocket")
		{
			Destroy(this.gameObject);
		}
	}
}
