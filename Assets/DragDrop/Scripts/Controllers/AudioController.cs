using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioController : MonoBehaviour {

	[Header("Music BackGround")]
	public AudioClip menuBackgroundMusic;
	public AudioClip gameBackgroundMusic;

	public AudioClip clickSound;

	public AudioSource playMusic;



	[Header("GameMain")]
	public AudioSource fraseSource;

	// Use this for initialization
	void Start () {
		playMusic.time = (PlayerPrefs.GetFloat("MenuMusic"));
		//playMusic.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			playMusic.PlayOneShot (clickSound);
		}
	}

	public void PlayFrase(){
		fraseSource.PlayOneShot(GameController.Instance.nivelGenerator.nivel.Audio);
	}

	public void SaveTimeMenuBackGroundMusic(){
		PlayerPrefs.SetFloat("MenuMusic", playMusic.time);
	}
}
