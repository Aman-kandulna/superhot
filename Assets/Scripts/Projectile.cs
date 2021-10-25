using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Projectile : MonoBehaviour
{

	public float projectileVelocity ;
	public GameObject bulletimpacteffect;
	public float bulletLife =3f;
	
	void Update ()
	{
		
		transform.Translate(projectileVelocity * transform.forward * Time.deltaTime,Space.World);
		if (bulletLife < 0)
		{
			Destroy(this.gameObject);
		}

		bulletLife -= Time.deltaTime;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			Instantiate(bulletimpacteffect,other.transform.position,Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
