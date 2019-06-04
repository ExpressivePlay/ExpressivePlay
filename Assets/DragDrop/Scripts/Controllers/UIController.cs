using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void LoadScene (string name){
		SceneManager.LoadScene (name);
		GameController.Instance.audiocontroller.SaveTimeMenuBackGroundMusic ();
	}

	public void LoadUrl(string url){
		Application.OpenURL (url);
	}

	[Header("GameMain UI")]
	public GameObject panelWin;

	public void NextLevel(){
		GameController.Instance.firebaseController.EnviarReport ();
		if (PlayerPrefs.GetInt ("debugOn", 0) == 1) {
			int aux = PlayerPrefs.GetInt ("SelectFase");
			aux += 1;
			PlayerPrefs.SetInt ("SelectFase", aux);
		}
	}

	public void LevelSelect(int nivel){
		PlayerPrefs.SetInt ("SelectNivel", nivel);
		if (PlayerPrefs.GetInt ("debugOn", 1) == 1) {
			PlayerPrefs.SetInt ("SelectFase", 0);
		}
	}
}