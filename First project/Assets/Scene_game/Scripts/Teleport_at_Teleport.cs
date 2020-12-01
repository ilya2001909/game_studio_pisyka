using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleport_at_Teleport : MonoBehaviour
{
	public Orintation_Display сторона;
	public Place_on_map place_On_Map;
	private float x;
	private float y;
	private float z;


	void Start() 
	{
		place_On_Map = GameObject.Find("Полажение игрока на карте").GetComponent<Place_on_map>();
		switch (сторона)
		{
			case Orintation_Display.Right:
				x = transform.position.x + 26;
				y = transform.position.y - 2.1f;
				z = transform.position.z;
				break;
			case Orintation_Display.Left:
				x = transform.position.x - 26;
				y = transform.position.y - 2.1f;
				z = transform.position.z;
				break;
			case Orintation_Display.Top:
				x = transform.position.x;
				y = transform.position.y - 2.1f;
				z = transform.position.z + 7f;
				break;
			case Orintation_Display.Botton:
				x = transform.position.x;
				y = transform.position.y - 2.1f;
				z = transform.position.z - 7f;
				break;
		}
	}


	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player")
		{
			Teleport(col.gameObject);
		}
	}


	private void Teleport(GameObject obj)
	{
		switch (сторона)
		{
			case Orintation_Display.Right:
				place_On_Map.x_pos++;
				break;
			case Orintation_Display.Left:
				place_On_Map.x_pos--;
				break;
			case Orintation_Display.Top:
				place_On_Map.y_pos++;
				break;
			case Orintation_Display.Botton:
				place_On_Map.y_pos--;
				break;
		}
		obj.GetComponent<CharacterController>().enabled = false;
		obj.transform.position = new Vector3(x, y, z);
		obj.GetComponent<CharacterController>().enabled = true;
	}

}