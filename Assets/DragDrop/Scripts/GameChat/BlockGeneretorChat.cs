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


	int imgRandom;

	// Use this for initialization
	void Start () {
		InstantietBlocksStart ();
		imgRandom = Random.Range (0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
		}
	}

	public void UpdateBlock(){
		if(GameControllerChat.Instance.panelFhaseChat.nextType.Count != 0){
			switch (GameControllerChat.Instance.panelFhaseChat.nextType.Count) {
			case 1:
				ResetOrgn ();
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels01) {
					if (aux.level == 2) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [1].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels02) {
					if (aux.level == 2) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [1].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels03) {
					if (aux.level == 2) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [1].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels04) {
					if (aux.level == 2) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [1].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels05) {
					if (aux.level == 2) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [1].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				InstantietBlocks ();
				break;
			case 2:
				ResetOrgn ();
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels01) {
					if (aux.level == 3) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0] && aux.blocos [1].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [1]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [2].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels02) {
					if (aux.level == 3) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0] && aux.blocos [1].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [1]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [2].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels03) {
					if (aux.level == 3) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0] && aux.blocos [1].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [1]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [2].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels04) {
					if (aux.level == 3) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0] && aux.blocos [1].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [1]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [2].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				foreach (Fase aux in GameControllerChat.Instance.dataBaseNivels.dataBaseNivels05) {
					if (aux.level == 3) {
						if (aux.blocos [0].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [0] && aux.blocos [1].tipo == GameControllerChat.Instance.panelFhaseChat.nextType [1]) {
							foreach(Palavra auxPalavra in GameControllerChat.Instance.dataBasePalavras.palavras){
								if (auxPalavra.tipo == aux.blocos [2].tipo) {
									blocks.Add (auxPalavra);
									auxBlocks.Add (auxPalavra);
								}
							}
						}
					}
				}
				InstantietBlocks ();
				break;
			}
		} else if(GameControllerChat.Instance.panelFhaseChat.nextType.Count == 0) {
			ResetOrgn ();
			InstantietBlocksStart ();
		}
	}

	public void ResetOrgn(){
		for (int x = 0; x < orgBlock.transform.childCount; x++) {
			Destroy (orgBlock.transform.GetChild (x).gameObject);
		}
		orgBlock.transform.position = new Vector2 (0, 0.5f);
		blocks.Clear ();
		auxBlocks.Clear();
	}

	public void InstantietBlocksStart(){
		int line = 1;
		int x = 0;
		int y = 0;
		foreach (Palavra aux in GameControllerChat.Instance.dataBasePalavras.palavras) {
			if (aux.tipo.StartsWith ("S") || aux.tipo.StartsWith ("V")) {
				blocks.Add (aux);
				auxBlocks.Add (aux);
			}
		}
		for (int xc = 0; xc < blocks.Count; xc++) {
			int randomBlock = Random.Range (0, auxBlocks.Count);
			GameObject auxBlock = Instantiate (block, new Vector2 (GameControllerChat.Instance.panelBlocks.pointsBlocks [0].position.x + x, GameControllerChat.Instance.panelBlocks.pointsBlocks [0].position.y + y), Quaternion.identity, orgBlock.transform);
			auxBlock.GetComponent<BlockChat> ().palavra = auxBlocks[randomBlock];
			auxBlock.GetComponent<SpriteRenderer> ().sprite = auxBlock.GetComponent<Block> ().palavra.imagem [imgRandom];
			auxBlock.GetComponent<BoxCollider2D> ().size = new Vector2 (2.50f, 2);
			auxBlocks.RemoveAt (randomBlock);
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

	public void InstantietBlocks(){
		int line = 1;
		int x = 0;
		int y = 0;
		for (int xc=0; xc < blocks.Count; xc++) {
			int randomBlock = Random.Range (0, auxBlocks.Count);
			GameObject auxBlock = Instantiate (block, new Vector2(GameControllerChat.Instance.panelBlocks.pointsBlocks[0].position.x + x, GameControllerChat.Instance.panelBlocks.pointsBlocks[0].position.y + y), Quaternion.identity, orgBlock.transform);
			//Adicionando as Informações
			auxBlock.GetComponent<BlockChat> ().palavra = auxBlocks[randomBlock];
			auxBlock.GetComponent<SpriteRenderer> ().sprite = auxBlock.GetComponent<Block> ().palavra.imagem [imgRandom];
			auxBlock.GetComponent<BoxCollider2D> ().size = new Vector2 (2.50f, 2);
			auxBlocks.RemoveAt (randomBlock);
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
