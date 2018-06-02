using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGeneretorChat : MonoBehaviour {

	public GameObject block;
	public GameObject orgBlock;

	public List<Palavra> blocks;
	public List<Palavra> auxBlocks;

	public List<GameObject> instanceBlocks;
	public bool canUpdate = true;

	// Use this for initialization
	void Start () {
		InstantietBlocksStart ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateBlock(){
		if (canUpdate) {
			canUpdate = false;

		}
	}

	public void InstantietBlocksStart(){
		int line = 1;
		int x = 0;
		int y = 0;
		foreach (Palavra aux in GameControllerChat.Instance.dataBasePalavras.palavras) {
			if (aux.tipo.StartsWith ("S") || aux.tipo.StartsWith ("V")) {
				GameObject auxBlock = Instantiate (block, new Vector2(GameControllerChat.Instance.panelBlocks.pointsBlocks[0].position.x + x, GameControllerChat.Instance.panelBlocks.pointsBlocks[0].position.y + y), Quaternion.identity, orgBlock.transform);
				auxBlock.GetComponent<Block> ().palavra = aux;
				//auxBlock.GetComponent<SpriteRenderer> ().sprite = auxBlock.GetComponent<Block> ().palavra.imagem [0];
				auxBlock.GetComponent<BoxCollider2D> ().size = new Vector2 (2.50f, 2);
				instanceBlocks.Add (auxBlock);
				if (line == 0) {
					x += 3;
					y += 2;
					line = 1;
				} else if (line == 1) {
					y -= 2;
					line = 0;
				}
			}
		}

	}

	public void InstantietBlocks(){
		for (int x=0; x < blocks.Count; x++) {
			int randomBlock = Random.Range (0, auxBlocks.Count);
			GameObject auxBlock = Instantiate (block, GameController.Instance.panelBlocks.pointsBlocks [x].position, Quaternion.identity, orgBlock.transform);
			//Adicionando as Informações
			auxBlock.GetComponent<Block> ().palavra = auxBlocks[randomBlock];
			//auxBlock.GetComponent<SpriteRenderer> ().sprite = auxBlock.GetComponent<Block> ().palavra.imagem [0];
			auxBlock.GetComponent<BoxCollider2D> ().size = new Vector2 (2.50f, 2);
			auxBlocks.RemoveAt (randomBlock);
		}
	}
}
