using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Unity.Editor;

public class FirebaseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnviarReport(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		GameController.Instance.nivelGenerator.nivel.reports.tries += 1;

		string a = System.DateTime.Now.GetDateTimeFormats ('u') [0].ToString ();
		a = a.Replace("-", "").Replace(":", "").Replace("Z", "");

		string date = a.Split (' ') [0];
		string hour = a.Split (' ') [1];
		if (PlayerPrefs.HasKey ("child")) {
			reference.Child("children").Child(PlayerPrefs.GetString("child")).Child("reports").Child(date).Child(hour).SetRawJsonValueAsync(JsonUtility.ToJson(GameController.Instance.nivelGenerator.nivel.reports));
		}

	}

}
