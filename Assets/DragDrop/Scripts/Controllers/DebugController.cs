using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugController : MonoBehaviour {

	public GameObject canvasDebug;

	[Header("Debug Fase")]
	public Text debugFase;


	[Header("Debug Palavras")]
	public Text debugGeneratePalavras;

	[Header("CheckBox Debug")]
	public GameObject checkboxDebug;


	int debugOn;



	// Use this for initialization
	void Start () {
		if (checkboxDebug != null) {
			if (PlayerPrefs.GetInt ("debugOn", 0) == 1) {
				checkboxDebug.GetComponent<Toggle> ().isOn = true;
			} else {
				checkboxDebug.GetComponent<Toggle> ().isOn = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (debugFase != null) {
			debugOn = PlayerPrefs.GetInt ("debugOn", 0);
			if (debugOn == 1) {
				canvasDebug.SetActive (true);
				string debugPalavras = "";
				foreach (Palavra aux in GameController.Instance.nivelGenerator.nivel.blocos) {
					debugPalavras = debugPalavras + aux.escrita + " - ";
				}
				debugFase.text = "Id: " + GameController.Instance.nivelGenerator.nivel.id + "\n" +
				"Nivel: " + GameController.Instance.nivelGenerator.nivel.level + "\n" +
				"Frase: " + GameController.Instance.nivelGenerator.nivel.frase + "\n" +
				"Codigo: " + GameController.Instance.nivelGenerator.nivel.answer + "\n" +
				"Palavras: \n" + debugPalavras;

				string palavrasFase = "";
				foreach (Palavra aux in GameController.Instance.panelBlocks.GetComponent<BlockGenerator>().blocks) {
					for (int x = 0; x < GameController.Instance.panelBlocks.GetComponent<BlockGenerator> ().orgBlock.childCount; x++) {
						Transform auxGenerate = GameController.Instance.panelBlocks.GetComponent<BlockGenerator> ().orgBlock.GetChild (x);
						if (aux.tipo == auxGenerate.GetComponent<Block> ().palavra.tipo) {
							palavrasFase = palavrasFase + aux.tipo + " - " + aux.escrita + " - V\n";
						}
					}
				}
				debugGeneratePalavras.text = palavrasFase;
			}
		}

		if (checkboxDebug != null) {
			if (checkboxDebug.GetComponent<Toggle> ().isOn) {
				PlayerPrefs.SetInt ("debugOn", 1);
			} else {
				PlayerPrefs.SetInt ("debugOn", 0);
			}
		}
	}
}
