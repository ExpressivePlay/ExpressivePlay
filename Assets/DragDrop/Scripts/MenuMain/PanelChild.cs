using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelChild : MonoBehaviour {

	public Text textName;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey ("child")) {
			textName.text = " Criança: " + PlayerPrefs.GetString ("child-name");
		} else {
			textName.text = " Criança: Convidado";
		}
		if (SceneManager.GetActiveScene ().name == "MenuConfig") {
			if (PlayerPrefs.HasKey ("child")) {
				logout.SetActive (true); 
			} else {
				login.SetActive (true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	[Header("MenuConfig")]
	public GameObject login;
	public GameObject logout;

	public void onLogout(){
		PlayerPrefs.DeleteKey ("child");
		PlayerPrefs.DeleteKey ("child-name");
		logout.SetActive (false);
		login.SetActive (true);
		textName.text = " Criança: Convidado";
	}

}
