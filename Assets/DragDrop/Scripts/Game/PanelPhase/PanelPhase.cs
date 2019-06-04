using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPhase : MonoBehaviour {

	public bool gameRunning = true;

	public GameObject lvlActive;
	public GameObject[] lvls;
	public GameObject[] tracado;

	public string answer;

	// Use this for initialization
	void Start () {

		//Gerando o Painel de Acordo com o lvl
		PointGenerate();

	}
	
	// Update is called once per frame
	void Update () {
		GetAnswer ();
		canValid ();
	}


	//Points Generator
	public void PointGenerate(){
		switch(GameController.Instance.nivelGenerator.nivel.level){
		case 1:
			lvls [0].SetActive (true);
			tracado[0].SetActive (true);
			lvlActive = lvls [0];
			break;
		case 2:
			lvls [1].SetActive (true);
			tracado[1].SetActive (true);
			lvlActive = lvls [1];
			break;
		case 3:
			lvls [2].SetActive (true);
			tracado[2].SetActive (true);
			lvlActive = lvls [2];
			break;

		}
	}

	public void GetAnswer(){
		answer = "";
		for(int x=0; x<lvlActive.transform.childCount; x++){
			Transform auxPoint = lvlActive.transform.GetChild (x);
			if (auxPoint.childCount != 0) {
				answer += auxPoint.GetChild (0).GetComponent<Block> ().palavra.tipo + "-";
			}
		}
	}

	public void ValidAnswer(){
		if (answer == GameController.Instance.nivelGenerator.nivel.answer) {
			gameRunning = false;
			GameController.Instance.uiController.panelWin.SetActive (true);
		} else {
			StartCoroutine (waitToResetBlockPos ());
		}
	}

	public void canValid(){
		if (lvlActive.transform.GetChild (lvlActive.transform.childCount - 1).childCount != 0) {
			ValidAnswer ();
		}
	}

	IEnumerator waitToResetBlockPos(){
		yield return new WaitForSeconds (1f);
		for (int x = 0; x < lvlActive.transform.childCount; x++) {
			lvlActive.transform.GetChild (x).GetChild (0).GetComponent<Block> ().ResetPos ();
		}
		GameController.Instance.nivelGenerator.nivel.reports.tries += 1;
		StopAllCoroutines();
	}
}
