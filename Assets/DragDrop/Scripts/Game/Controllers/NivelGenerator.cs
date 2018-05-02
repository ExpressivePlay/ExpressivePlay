using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelGenerator : MonoBehaviour {
	
	public Fase nivel;
	int selectNivel;
	public bool loaded = false;

	// Use this for initialization
	void Awake () {
		GetFase ();
		nivel.reports = new Reports ();
		nivel.reports.level = nivel.level;
		nivel.reports.combination = nivel.frase;
	}

	void Start(){
		GameController.Instance.audiocontroller.PlayFrase ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GetFase(){
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
