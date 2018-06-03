using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelActive : MonoBehaviour {

	public Fase fase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fase.frase != "") {
			GameControllerChat.Instance.uiController.textPhrase.text = fase.frase;
		}
	}

	public void SetFase(){
		foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels01) {
			if (GameControllerChat.Instance.panelFhaseChat.answer == aux.answer) {
				fase = aux;
			}
		}
		foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels02) {
			if (GameControllerChat.Instance.panelFhaseChat.answer == aux.answer) {
				fase = aux;
			}
		}
		foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels03) {
			if (GameControllerChat.Instance.panelFhaseChat.answer == aux.answer) {
				fase = aux;
			}

		}
		foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels04) {
			if (GameControllerChat.Instance.panelFhaseChat.answer == aux.answer) {
				fase = aux;
			}
		}
		foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels05) {
			if (GameControllerChat.Instance.panelFhaseChat.answer == aux.answer) {
				fase = aux;
			}
		}
	}

	public void PlayAudio(){
		if (fase != null) {
			GameControllerChat.Instance.audiocontroller.fraseSource.PlayOneShot (fase.Audio);
		}
	}
}
