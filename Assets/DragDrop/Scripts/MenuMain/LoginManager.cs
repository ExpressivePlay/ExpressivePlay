﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase.Database;
using Firebase.Unity.Editor;

public class LoginManager : MonoBehaviour {

	public Reports report;

	//campo do usuario
	[SerializeField]
	private InputField usuarioFild = null;
	//campo da senha
	[SerializeField]
	private InputField senhaFild = null;
	//mensagem de feedback
	[SerializeField]
	private Text feedBackmsg = null;

	private string url= "http://www.expressiveplay.tk/loginUnity/login.php";
	// Use this for initialization
	void Start () {
		print (System.DateTime.Now.Month.ToString ());
		print (System.DateTime.Now.GetDateTimeFormats('u')[0].ToString());
		string a = System.DateTime.Now.GetDateTimeFormats ('u') [0].ToString ();
		a = a.Replace("-", "").Replace(":", "").Replace("Z", "");
		print (a.Split (' ') [0]);
		print (a.Split (' ') [1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FazerLogin2(){

		if(usuarioFild.text == "" || senhaFild.text ==""){
			FeedBackErro ("PREENCHA TODOS OS CAMPOS!");
		}else{
		string login = usuarioFild.text;
		string pass = senhaFild.text;

		WWW www = new WWW (url + "?login=" + login + "&pass=" + pass);
		StartCoroutine (ValidaLogin(www));
		}
	}

	public void FazerLogin(){
		if(usuarioFild.text == "" || senhaFild.text ==""){
			FeedBackErro ("PREENCHA TODOS OS CAMPOS!");
		}else{
			string login = usuarioFild.text;
			string pass = senhaFild.text;


			DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
			print (reference.Database.GetReference ("children").GetValueAsync ().ContinueWith (task => {
				if (task.IsFaulted) {
					FeedBackErro ("SERVIDOR INDISPONIVEL");
				} else if (task.IsCompleted) {
					DataSnapshot snapshot = task.Result;
					if(snapshot.Child(login).Exists){
						if(snapshot.Child(login).Child("pass").Value.ToString() == pass){
							FeedBackOk ("LOGIN EFETUADO COM SUCESSO!\nCARREGANDO...");
							PlayerPrefs.SetString("child", login);
							StartCoroutine(CarregaScene());
						} else {
							FeedBackErro ("LOGIN OU SENHA INCORRETO");
						}
					} else {
						FeedBackErro ("LOGIN OU SENHA INCORRETO");
					}
				}

			}));
		}
	}

	IEnumerator ValidaLogin(WWW www){
		yield return www;
		if (www.error == null) {
			if (www.text == "1") {
				FeedBackOk ("LOGIN EFETUADO COM SUCESSO!\nCARREGANDO...");

				StartCoroutine (CarregaScene ());
			} else {
				FeedBackErro ("LOGIN OU SENHA INCORRETO");
			}

		} else {
			if (www.error == "couldn't connect to host") {
				FeedBackErro ("SERVIDOR INDISPONIVEL");
			}
			//mensagem de erro pois não conseguiu acessar o site
		}
	}

	IEnumerator CarregaScene(){
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("Main");
	}

	void FeedBackOk(string mensagem){
		feedBackmsg.CrossFadeAlpha (150f, 1f, false);
		feedBackmsg.color = Color.green;
		feedBackmsg.text = mensagem;
		feedBackmsg.CrossFadeAlpha (0f, 3f, false);
	}

	void FeedBackErro(string mensagem){
		feedBackmsg.CrossFadeAlpha (100f, 1f, false);
		feedBackmsg.color = Color.red;
		feedBackmsg.text = mensagem;
		feedBackmsg.CrossFadeAlpha (0f, 4f, false);
		usuarioFild.text = "";
		senhaFild.text = "";
	}

	public void VoltarMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void EnviarReport(){
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

		string date = System.DateTime.Now.Year.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString();
		string hour = System.DateTime.Now.Hour.ToString () + System.DateTime.Now.Minute.ToString () + System.DateTime.Now.Second.ToString ();
		print (date + " " + hour);

		string json = JsonUtility.ToJson (report); 
		print (json);
		reference.Child("children").Child(PlayerPrefs.GetString("child")).Child("reports").Child(date).Child(hour).SetRawJsonValueAsync(JsonUtility.ToJson(report));

	}
}
