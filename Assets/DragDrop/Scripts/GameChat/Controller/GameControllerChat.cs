using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerChat : MonoBehaviour {

	private static GameControllerChat instance;
	public static GameControllerChat Instance{
		get {
			if(instance == null){
			instance = FindObjectOfType <GameControllerChat>();
			}
			return instance;
		}

	}

	[Header("Scene Game")]
	public PanelBlocks panelBlocks;
	public PanelFhaseChat panelFhaseChat;
	public BlockGeneretorChat blockGeneratorChat;
	public PointUIChat pointUIChat;
	public NivelActive nivelActive;

	[Header("UI Controller")]
	public UiControllerChat uiController;

	[Header("FireBase Controller")]
	public FirebaseControllerChat firebaseController;

	[Header("Audio Controller")]
	public AudioController audiocontroller;

	[Header("ScriptableObject")]
	public DataBaseNivels dataBaseNivels;
	public Palavras dataBasePalavras;

	// Use this for initialization
	void Start () {

	}
}
