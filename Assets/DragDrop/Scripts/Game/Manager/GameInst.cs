using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInst : MonoBehaviour {

	private static GameInst instance;
	public static GameInst Instance{
		get {
			if(instance == null){
				instance = FindObjectOfType <GameInst>();
			}
			return instance;
		}

	}

	//public static Game
	public GameController gameController;
	public NivelGenerator nivelGenerator;		//Coleta as Informações da Fase
	public DataBaseNivels dataBaseNivels;
	public PlayerPrefsController playerPrefsController;
	public PanelBlocks panelBlocks;
	public PanelPhase panelPhase;
	public PointUI pointUI;

	// Use this for initialization
	void Start () {
		
	}


}
