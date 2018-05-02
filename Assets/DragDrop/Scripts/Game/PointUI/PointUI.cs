using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointUI : MonoBehaviour {

	[Header("Posição da Frase")]
	public GameObject pointPhrase;
	public Text textPhrase;

	[Header("Posição do Botão")]
	public GameObject pointPlay;
	public GameObject playButton;

	// Use this for initialization
	void Start () {
		SetButtonPlayPosition ();
		SetPhrasePosition ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetPhrasePosition(){
		textPhrase.text = GameController.Instance.nivelGenerator.nivel.frase;
		textPhrase.transform.position = Camera.main.WorldToScreenPoint(pointPhrase.transform.position);
	}

	void SetButtonPlayPosition(){
		playButton.transform.position = Camera.main.WorldToScreenPoint (pointPlay.transform.position);
	}
}
