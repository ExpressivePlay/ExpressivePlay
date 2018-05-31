using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour {

	public List<Palavra> blocks;

	public List<Palavra> auxBlocks; //Auxiliar para o InstantietBlocks, Fazendo a criação de blocos aleatoria

	public GameObject block;

	public Transform orgBlock;

	// Use this for initialization
	void Start () {
		
		//Puxa as informações dos Blocos do FaseGenerator
		CatchPhases();

		//Instancia Todos os Blocos com suas informações
		InstantietBlocks ();

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void CatchPhases(){
		for (int x = 0; x < GameController.Instance.nivelGenerator.nivel.blocos.Count; x++) {	//Percorre os Blocos da Classe
			blocks.Add (GameController.Instance.nivelGenerator.nivel.blocos[x]);
			auxBlocks.Add (GameController.Instance.nivelGenerator.nivel.blocos[x]);  //Auxiliar para o InstantietBlocks, Fazendo a criação de blocos aleatoria

			int count = 0;
			switch (GameController.Instance.nivelGenerator.nivel.level) {
			case 1:
				while (true) {
					int random = Random.Range (0, GameController.Instance.dataBasePalavras.palavras.Count);
					if (GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("S") || GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("V")) {
						blocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						auxBlocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						count++;
						if(count == 2){
							break;
						}
					}
				}
				break;
			case 2:
				while (true) {
					int random = Random.Range (0, GameController.Instance.dataBasePalavras.palavras.Count);
					if (GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("S") || GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("V")) {
						blocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						auxBlocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						count++;
						if(count == 2){
							break;
						}
					}
				}
				break;
			case 3:
				while (true) {
					int random = Random.Range (0, GameController.Instance.dataBasePalavras.palavras.Count);
					if (GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("S") || GameController.Instance.dataBasePalavras.palavras [random].tipo.StartsWith ("V")) {
						blocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						auxBlocks.Add (GameController.Instance.dataBasePalavras.palavras [random]);
						count++;
						if(count == 2){
							break;
						}
					}
				}
				break;
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