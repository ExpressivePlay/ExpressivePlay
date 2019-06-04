using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSelect : MonoBehaviour {

	public GameObject nivel;
	public GameObject[] points;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		//StartCoroutine ("Wait1Second");
		//CreateNivels();	
	}
	
	// Update is called once per frame
	void Update () {
		//print(GameInst.Instance.dataBaseNivels.dataBaseNivels.Count);
	}


	/*
	public void CreateNivels(){
		int countPoint = 0; //Contador dos pontos
		for(int x=0; x<GameController.Instance.dataBaseNivels.dataBaseNivels.Count; x++){
			if (GameController.Instance.dataBaseNivels.dataBaseNivels [x].level == 1) {
				GameObject auxNivel = Instantiate (nivel, canvas.transform);
				auxNivel.GetComponent<NivelUI> ().id = GameController.Instance.dataBaseNivels.dataBaseNivels [x].id;
				auxNivel.GetComponent<NivelUI> ().idText.text = (countPoint+1).ToString();
				auxNivel.GetComponent<Transform> ().position = Camera.main.WorldToScreenPoint(points[countPoint].transform.position);
				countPoint++;
			}
		}
		for (int x = 0; x < GameController.Instance.dataBaseNivels.dataBaseNivels.Count; x++) {
			if (GameController.Instance.dataBaseNivels.dataBaseNivels [x].level == 2) {
				GameObject auxNivel = Instantiate (nivel, canvas.transform);
				auxNivel.GetComponent<NivelUI> ().id = GameController.Instance.dataBaseNivels.dataBaseNivels [x].id;
				auxNivel.GetComponent<NivelUI> ().idText.text = (countPoint+1).ToString();
				auxNivel.GetComponent<Transform> ().position = Camera.main.WorldToScreenPoint(points[countPoint].transform.position);
				countPoint++;
			}
		}
		for (int x = 0; x < GameController.Instance.dataBaseNivels.dataBaseNivels.Count; x++) {
			if (GameController.Instance.dataBaseNivels.dataBaseNivels [x].level == 3) {
				GameObject auxNivel = Instantiate (nivel, canvas.transform);
				auxNivel.GetComponent<NivelUI> ().id = GameController.Instance.dataBaseNivels.dataBaseNivels [x].id;
				auxNivel.GetComponent<NivelUI> ().idText.text = (countPoint+1).ToString();
				auxNivel.GetComponent<Transform> ().position = Camera.main.WorldToScreenPoint(points[countPoint].transform.position);
				countPoint++;
			}
		}
	}

	IEnumerator Wait1Second(){
		yield return new WaitForSeconds (1f);
		CreateNivels ();
	}*/
}
