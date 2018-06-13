using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

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

	public void SendNotification(){
		if (PlayerPrefs.HasKey ("child")) {
			//Firebase
			DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

			//Hora
			string a = System.DateTime.Now.GetDateTimeFormats ('u') [0].ToString ();
			a = a.Replace ("-", "").Replace ("Z", "");

			string date = a.Split (' ') [0];
			string hour = a.Split (' ') [1];

			string jsonStr = "";

			//Data
			PostData data = new PostData ();
			data.cod = GameController.Instance.nivelGenerator.nivel.frase;
			data.hora = hour;

			//NOtifiation
			PostNote not = new PostNote ();
			not.title = "Fase completada!";
			not.body = PlayerPrefs.GetString ("child-name") + " completou a frase: " + GameController.Instance.nivelGenerator.nivel.frase + ". Parabenize-o!";
			not.icon = "img/icone.png";

			PostObject aa = new PostObject ();
			reference.Database.GetReference ("children").GetValueAsync ().ContinueWith (task => {
				if (task.IsCompleted) {
					DataSnapshot snapshot = task.Result;
					aa.data = data;
					aa.notification = not;
					aa.to = "/topics/" + snapshot.Child (PlayerPrefs.GetString ("child")).Child ("caregiver").Value.ToString ();
					jsonStr = JsonUtility.ToJson (aa);

					WWWForm form = new WWWForm ();
					form.AddField ("name", "value");
					Dictionary<string, string> headers = form.headers;
					byte[] rawData = System.Text.Encoding.UTF8.GetBytes (jsonStr);
					string url = "https://fcm.googleapis.com/fcm/send";

					// Add a custom header to the request.
					// In this case a basic authentication to access a password protected resource.

					headers ["Content-Type"] = "application/json";
					headers ["Authorization"] = "key=AIzaSyBqitOEyrJzCRCGhwDhg54jrj6h_HRLZC4";

					/*
				headers.Add("Content-Type", "application/json");
				headers.Add("Authorization", "key=AIzaSyBqitOEyrJzCRCGhwDhg54jrj6h_HRLZC4");
				*/
					// Post a request to an URL with our custom headers
					WWW www = new WWW (url, rawData, headers);

					StartCoroutine (WaitForRequest (www));
				}
			});


		}
	}

	IEnumerator WaitForRequest(WWW data){
		yield return data; // Wait until the download is done
		if (data.error != null){
			print("There was an error sending request: " + data.error);
			print("WWW Request: " + data.text);
		}
		else{
			print("WWW Request: " + data.text);
		}
	}
}


