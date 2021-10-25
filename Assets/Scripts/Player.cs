using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

	private CharacterController _characterController;
	public Transform firePosition;
	public GameObject ProjectilePrefab;
	public Text timeViewer;
	public float speed =50f;
	private Vector3 movement;
	private Vector3 move;
	public float changeRate = 2f;
	
	void Start ()
	{
		_characterController = GetComponent<CharacterController>();
		Time.timeScale = 0;

	}
	
	
	private void Update ()
	{

		var x= Input.GetAxisRaw("Horizontal");
		var z= Input.GetAxisRaw("Vertical");
		move = transform.right * x + transform.forward * z;
		_characterController.Move(move * speed * Time.unscaledDeltaTime);
		if (move.magnitude == 0)
		{
			SlowTime();
		}
		else
		{
			NormalTime();
			
		}
		if (Input.GetKeyDown(KeyCode.Mouse0))
			Shoot();

		timeViewer.text = Time.timeScale + "";

	}

	private void SlowTime()
	{
		if(Time.timeScale >0.1)
			Time.timeScale -= Time.unscaledDeltaTime * changeRate;
		
	}

	private void NormalTime()
	{
		if(Time.timeScale < 1)
			Time.timeScale += Time.unscaledDeltaTime * changeRate;
	}
	
	private void Shoot()
	{
		Instantiate(ProjectilePrefab, firePosition.position, firePosition.rotation);
	}

	
}
