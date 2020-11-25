using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Orintation_Display
{
	//
	// Сводка:
	//     Location service is stopped.
	Right = 0,
	//
	// Сводка:
	//     Location service is initializing, some time later it will switch to.
	Left = 1,
	//
	// Сводка:
	//     Location service is running and locations could be queried.
	Top = 2,
	//
	// Сводка:
	//     Location service failed (user denied access to location service).
	Botton = 3
}

public class Teleport_at_Teleport : MonoBehaviour
{
	public Check_active check_Active;
	private GameObject player;
	private bool teleported;

	public Orintation_Display сторона; 

	private float x;
	private float y;
	private float z;

	void Start() 
	{
		check_Active = gameObject.GetComponentInParent<Check_active>();
		if (сторона == Orintation_Display.Botton)
		{
			x = transform.position.x;
			y = transform.position.y - 2.1f;
			z = transform.position.z - 7f;
		}
		if (сторона == Orintation_Display.Left)
		{
			x = transform.position.x - 26;
			y = transform.position.y - 2.1f;
			z = transform.position.z;
		}
		if (сторона == Orintation_Display.Right)
		{
			x = transform.position.x + 26;
			y = transform.position.y - 2.1f;
			z = transform.position.z;
		}
		if (сторона == Orintation_Display.Top)
		{
			x = transform.position.x;
			y = transform.position.y - 2.1f;
			z = transform.position.z + 7f;
		}
	}
	

	void Update()
	{
		if (teleported) Teleport(player.transform);
	}

    private void Teleport(Transform obj)
	{
		player.GetComponent<CharacterController>().enabled = false;
		obj.transform.position = new Vector3(x, y, z);
		teleported = false;
		player.GetComponent<CharacterController>().enabled = true;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			player = col.gameObject;
			teleported = true;
			check_Active.IsActive = false;
			check_Active.cam = null;
			check_Active.player = null;


			foreach (ParticleSystem p in check_Active.particles)
			{
				p.gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.tag == "Player")
		{
			player = null;
			teleported = false;
		}
	}

}