using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour {

	public List<GameObject> stars;

	// Use this for initialization
	void Start () {
		switch (GameController.Instance.nivelGenerator.nivel.reports.tries) {
		case 0:
			stars [2].SetActive (true);
			break;
		case 1:
			stars [1].SetActive (true);
			break;
		default:
			stars [0].SetActive (true);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
