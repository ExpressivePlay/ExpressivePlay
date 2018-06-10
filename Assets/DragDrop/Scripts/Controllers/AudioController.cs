using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioController : MonoBehaviour {

	[Header("Music BackGround")]
	public AudioClip menuBackgroundMusic;
	public AudioClip gameBackgroundMusic;

	public AudioClip clickSound;

	public AudioSource playMusic;

	public GameObject checkAudio;

	[Header("GameMain")]
	public AudioSource fraseSource;




	int audioOn;

	// Use this for initialization
	void Start () {
		SetAudioCheck ();
		playMusic.time = (PlayerPrefs.GetFloat("MenuMusic"));
		//playMusic.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			playMusic.PlayOneShot (clickSound);
		}

		SetAudio ();

	}

	public void PlayFrase(){
		fraseSource.PlayOneShot(GameController.Instance.nivelGenerator.nivel.Audio);
	}

	public void SaveTimeMenuBackGroundMusic(){
		PlayerPrefs.SetFloat("MenuMusic", playMusic.time);
	}

	public void SetAudio(){
		audioOn = PlayerPrefs.GetInt("audioOn", 1);
		if (audioOn == 1) {
			playMusic.volume = 0.1f;
		} else {
			playMusic.volume = 0.0f;
		}

		if (checkAudio != null) {
			if (checkAudio.GetComponent<Toggle> ().isOn) {
				PlayerPrefs.SetInt ("audioOn", 1);
			} else {

				PlayerPrefs.SetInt ("audioOn", 0);
			}
		}
	}

	public void SetAudioCheck(){
		if (checkAudio != null) {
			audioOn = PlayerPrefs.GetInt ("audioOn", 1);
			if (audioOn == 1) {
				checkAudio.GetComponent<Toggle> ().isOn = true;
			} else {
				checkAudio.GetComponent<Toggle> ().isOn = false;
			}
		}
	}
}
