using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	public GameObject gameObjectHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MousePos ();  //  Saber a posição do mouse

		gameObjectHit = GetObjetMouseCol (); 		// Pegar Objeto que o mouse passa

	}



	public GameObject GetObjetMouseCol(){  // Retorna o objeto que o mouse colide
		Vector2 rayPos = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y); // Pegando a posição do Mouse
		RaycastHit2D hit = Physics2D.Raycast (rayPos, Vector2.zero, 0f);	// RayCast no mouse

		if (hit) {
			return hit.transform.gameObject;  // objeto que o mouse colide
		} else {
			return null;
		}
	}

	public Vector3 MousePos(){
		Vector3 posMous = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		return new Vector3 (posMous.x, posMous.y, 0);
	}
}
