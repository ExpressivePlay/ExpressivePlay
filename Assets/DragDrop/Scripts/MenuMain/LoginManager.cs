using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginManager : MonoBehaviour {

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FazerLogin(){

		if(usuarioFild.text == "" || senhaFild.text ==""){
			FeedBackErro ("PREENCHA TODOS OS CAMPOS!");
		}else{
		string login = usuarioFild.text;
		string pass = senhaFild.text;

		WWW www = new WWW (url + "?login=" + login + "&pass=" + pass);
		StartCoroutine (ValidaLogin(www));
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
}
