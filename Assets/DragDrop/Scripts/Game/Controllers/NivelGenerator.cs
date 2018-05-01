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
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GetFase(){
		selectNivel = PlayerPrefs.GetInt ("SelectNivel");
		switch (selectNivel) {
		case 1:
			for(int x=0; x<GameController.Instance.dataBaseNivels.dataBaseNivels01.Count; x++){ // Procura o Nivel Pelo ID
				if(GameController.Instance.dataBaseNivels.dataBaseNivels01[x].id == selectNivel ){
					nivel = GameController.Instance.dataBaseNivels.dataBaseNivels01 [x];
					loaded = true;
				}
			}
			break;
		case 2:
			for(int x=0; x<GameController.Instance.dataBaseNivels.dataBaseNivels02.Count; x++){ // Procura o Nivel Pelo ID
				if(GameController.Instance.dataBaseNivels.dataBaseNivels02[x].id == selectNivel ){
					nivel = GameController.Instance.dataBaseNivels.dataBaseNivels02 [x];
					loaded = true;
				}
			}
			break;
		case 3:
			for(int x=0; x<GameController.Instance.dataBaseNivels.dataBaseNivels02.Count; x++){ // Procura o Nivel Pelo ID
				if(GameController.Instance.dataBaseNivels.dataBaseNivels02[x].id == selectNivel ){
					nivel = GameController.Instance.dataBaseNivels.dataBaseNivels02 [x];
					loaded = true;
				}
			}
			break;


		}
	}

}
