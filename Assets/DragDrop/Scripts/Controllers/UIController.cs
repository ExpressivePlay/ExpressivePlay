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
	}

	public void LevelSelect(int nivel){
		PlayerPrefs.SetInt ("SelectNivel", nivel);
	}

}