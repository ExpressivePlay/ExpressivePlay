using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelChild : MonoBehaviour {

	public Text textName;

	// Use this for initialization
	void Start () {
		textName.text = " Criança: " + PlayerPrefs.GetString ("child-name");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
