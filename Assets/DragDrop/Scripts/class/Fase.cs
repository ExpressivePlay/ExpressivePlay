using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fase{

	public int id;
	public int level;
	public string frase;
	public string answer;
	public List<Palavra> blocos;
	public Reports reports;
	public AudioClip Audio;

}
