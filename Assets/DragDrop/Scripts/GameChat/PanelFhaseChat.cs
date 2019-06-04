using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFhaseChat : MonoBehaviour {


	public GameObject points;

	public string answer;

	public string frase;

	public List<string> nextType;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetAnswer ();
		GetNextType ();

		if (answer != "") {
			frase = GameControllerChat.Instance.nivelActive.fase.frase.ToString();
			GameControllerChat.Instance.uiController.textPhrase.text = frase;
			GameControllerChat.Instance.uiController.btnPlayAudio.interactable = true;
		} else {
			GameControllerChat.Instance.uiController.btnPlayAudio.interactable = false;
			GameControllerChat.Instance.uiController.textPhrase.text = "Arraste um bloco";
		}

	}

	public void GetAnswer(){
		answer = "";
		for(int x=0; x<points.transform.childCount; x++){
			Transform auxPoint = points.transform.GetChild (x);
			if (auxPoint.childCount != 0) {
				answer += auxPoint.GetChild (0).GetComponent<BlockChat> ().palavra.tipo + "-";
			}
		}
	}

	public void GetNextType(){
		nextType.Clear ();
		for(int x=0; x<points.transform.childCount; x++){
			Transform auxPoint = points.transform.GetChild (x);
			if (auxPoint.childCount != 0) {
				nextType.Add (auxPoint.GetChild (0).GetComponent<BlockChat> ().palavra.tipo);
			}
		}
	}
}
