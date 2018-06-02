using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOrgBlocks : MonoBehaviour {

	public bool moveLeft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (moveLeft) {
			if (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x > -81) {
				GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position = new Vector2 (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x - 3, GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.y);
			}
		} else {
			if (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x < 0) {
				GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position = new Vector2 (GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.x + 3, GameControllerChat.Instance.panelBlocks.GetComponent<BlockGeneretorChat> ().orgBlock.transform.position.y);
			}
		}
	}
}
