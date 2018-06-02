using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelGenerator : MonoBehaviour {
	
	public bool gerarPeloId;
	public Fase nivel;
	int selectNivel;
	bool loaded = false;

	// Use this for initialization
	void Awake () {
		GetFase ();
		FindWord ();
		nivel.reports = new Reports ();
		nivel.reports.level = nivel.level;
		nivel.reports.combination = nivel.frase;
	}

	void Start(){
		StartCoroutine (playFhase ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GetFase(){
		if (gerarPeloId) {
			foreach (Fase aux in GameController.Instance.dataBaseNivels.dataBaseNivels01) {
				if (aux.id == nivel.id) {
					nivel = aux;
				}
			}
			foreach (Fase aux in GameController.Instance.dataBaseNivels.dataBaseNivels02) {
				if (aux.id == nivel.id) {
					nivel = aux;
				}
			}
			foreach (Fase aux in GameController.Instance.dataBaseNivels.dataBaseNivels03) {
				if (aux.id == nivel.id) {
					nivel = aux;
				}
			}
		} else {
			selectNivel = PlayerPrefs.GetInt ("SelectNivel");
			switch (selectNivel) {
			case 1:
				nivel = GameController.Instance.dataBaseNivels.dataBaseNivels01 [Random.Range (0, GameController.Instance.dataBaseNivels.dataBaseNivels01.Count)];
				loaded = true;
				break;
			case 2:
				nivel = GameController.Instance.dataBaseNivels.dataBaseNivels02 [Random.Range (0, GameController.Instance.dataBaseNivels.dataBaseNivels02.Count)];
				loaded = true;
				break;
			case 3:
				nivel = GameController.Instance.dataBaseNivels.dataBaseNivels02 [Random.Range (0, GameController.Instance.dataBaseNivels.dataBaseNivels03.Count)];
				loaded = true;
				break;
			}
		}
	}

	public void FindWord(){
		switch (nivel.level) {
		case 1:
			foreach (Palavra aux in GameController.Instance.dataBasePalavras.palavras) {
				if (nivel.blocos [0].tipo == aux.tipo) {
					nivel.blocos [0] = aux;
				}
			}
			break;
		case 2:
			foreach (Palavra aux in GameController.Instance.dataBasePalavras.palavras) {
				if (nivel.blocos [0].tipo == aux.tipo) {
					nivel.blocos [0] = aux;
				}
				if (nivel.blocos [1].tipo == aux.tipo) {
					nivel.blocos [1] = aux;
				}
			}
			break;
		case 3:
			foreach (Palavra aux in GameController.Instance.dataBasePalavras.palavras) {
				if (nivel.blocos [0].tipo == aux.tipo) {
					nivel.blocos [0] = aux;
				}
				if (nivel.blocos [1].tipo == aux.tipo) {
					nivel.blocos [1] = aux;
				}
				if (nivel.blocos [2].tipo == aux.tipo) {
					nivel.blocos [2] = aux;
				}
			}
			break;
		}
	}

	IEnumerator playFhase(){
		yield return new WaitForSeconds (1f);
		GameController.Instance.audiocontroller.PlayFrase ();
	}
}
