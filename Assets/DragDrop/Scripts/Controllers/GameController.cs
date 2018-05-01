using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	private static GameController instance;
	public static GameController Instance{
		get {
			if(instance == null){
				instance = FindObjectOfType <GameController>();
			}
			return instance;
		}

	}

	[Header("Scene Game")]
	public NivelGenerator nivelGenerator;		//Coleta as Informações da Fase
	public DataBaseNivels dataBaseNivels;
	public PlayerPrefsController playerPrefsController;
	public PanelBlocks panelBlocks;
	public PanelPhase panelPhase;
	public PointUI pointUI;

	[Header("UI Controller")]
	public UIController uiController;

	[Header("FireBase Controller")]
	public FirebaseController firebaseController;

	// Use this for initialization
	void Start () {
		
	}


}
