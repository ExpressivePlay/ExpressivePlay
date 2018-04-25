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
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GetFase(){
		selectNivel = PlayerPrefs.GetInt ("SelectNivel");
		for(int x=0; x<GameController.Instance.dataBaseNivels.dataBaseNivels.Count; x++){ // Procura o Nivel Pelo ID
			if(GameController.Instance.dataBaseNivels.dataBaseNivels[x].id == selectNivel ){
				nivel = GameController.Instance.dataBaseNivels.dataBaseNivels [x];
				loaded = true;
			}
		}
	}

}
