using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOrgBlocks : MonoBehaviour {

	public bool moveRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (moveRight) {
			Transform aux = null;
			int quantOrgChild = GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.childCount;
			if (quantOrgChild != 0) {
				aux = GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.GetChild (quantOrgChild-1);
				if (aux.transform.position.x > 3f) {
					GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position = new Vector2 (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x - 3, GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.y);
				}
			}
		} else {
			if (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x < 0) {
				GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position = new Vector2 (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x + 3, GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.y);
			}
		}
	}
}
