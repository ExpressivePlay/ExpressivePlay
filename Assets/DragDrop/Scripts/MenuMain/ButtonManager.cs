using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AbrirTelaIniciar(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void AcessarConfig(){
		SceneManager.LoadScene ("MenuConfig");
	}

	public void AbrirURL(){
		Application.OpenURL ("http://www.expressiveplay.tk/");
	}

	public void AbrirTelaLogin(){
		SceneManager.LoadScene ("Login");
	}
}
