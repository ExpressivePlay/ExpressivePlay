using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NivelUI : MonoBehaviour {

	public int id;
	public Image nivelImg;
	public Text idText;
	public GameObject stars;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		PlayerPrefs.SetInt ("SelectNivel", id);
		SceneManager.LoadScene ("GameMain");
	}

}
