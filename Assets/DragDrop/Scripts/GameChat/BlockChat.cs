using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChat : MonoBehaviour {




	Transform myTranform;
	Vector3 posIni;
	Vector3 posPoint;

	bool inPanel = false;
	Transform auxPoint;

	//  Informações
	public Palavra palavra;

	// Use this for initialization
	void Start () {
		myTranform = GetComponent<Transform> ();
		posIni = myTranform.position;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		//print ("Clikei");
	}

	void OnMouseDrag(){
		myTranform.position = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
		//print ("Arrasta");
	}

	void OnMouseUp(){
		if (inPanel) {
			myTranform.position = posPoint;
			this.transform.parent = auxPoint.transform;
			GameControllerChat.Instance.blockGeneratorChat.UpdateBlock ();
			GameControllerChat.Instance.nivelActive.SetFase ();
		} else {
			myTranform.position = posIni;
			GameControllerChat.Instance.blockGeneratorChat.UpdateBlock ();
		}
	}


	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.CompareTag ("Panel")) {
			for(int x=0; x<col.GetComponent<PanelFhaseChat> ().points.transform.childCount; x++){		//Verifica quantos filhos 
				auxPoint = col.GetComponent<PanelFhaseChat> ().points.transform.GetChild(x);
				if (auxPoint.childCount == 0) {
					this.transform.parent = auxPoint.transform;
					posPoint = auxPoint.transform.position;
					inPanel = true;
					break;
				}
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.CompareTag ("Panel")) {

		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.CompareTag ("Panel")) {
			inPanel = false;
			gameObject.transform.parent = GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat>().orgBlock.transform;
		}
	}

	public void ResetPos(){
		myTranform.position = posIni;
	}
}
