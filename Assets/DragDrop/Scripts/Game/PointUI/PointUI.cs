using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUI : MonoBehaviour {


	public GameObject pointPhrase;
	public Text textPhrase;

	// Use this for initialization
	void Start () {
		SetPhrasePosition ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetPhrasePosition(){
		textPhrase.text = GameController.Instance.nivelGenerator.nivel.frase;
		textPhrase.transform.position = Camera.main.WorldToScreenPoint(pointPhrase.transform.position);
	}
}
