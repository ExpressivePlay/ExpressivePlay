using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelSelect : MonoBehaviour {

	public int id;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp(){
		PlayerPrefs.SetInt ("SelectNivel", id);
		SceneManager.LoadScene ("GameMain");
	}
}
