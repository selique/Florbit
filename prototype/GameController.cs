using UnityEngine;
using System.Collections;

public class FormaFrase : MonoBehaviour {
	public Text textLetra;
	public Text textPalavra;
	private int numCorretasLetras;
	private int numLetras;
	private int contTentativas;
	
	// Use this for initialization
	void Start () {
		contTentativas = 0;
		textLetraCapturada.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other) 
	{

	var gos : GameObject[];
        gos = GameObject.FindGameObjectsWithTag("vaca"); 
  
        if (gos.length == 0) {
            Debug.Log("O objeto nao contem a palavra procurada");
        }
        
       	for (int i = 0; i < textPalavra.Length; i++) {
	 	numLetras++;
	 	if(gameObject.tag = Left(textPalavra, i)) {
	 		displayLetter == true;
	 	} else if {
	 		displayLetter == false;
	 		contTentativas++;
	 	}
	}

		if (other.gameObject.CompareTag (Tag_letra_A)) {
			//other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			textLetra.text = textLetra.text + "";//caso pegue o cubo vazio zera o conteudo
		} else if {
			contTentativas ++;
		}
		
		
		
		
		//verifica se a Tag contem a palavra cube
		if (other.gameObject.tag.ToString ().Contains ("Cube") == true) {
			//other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			//Pega a ultima letra da TAG
			textLetra.text = textLetra.text + other.gameObject.tag.ToString ().Substring (other.gameObject.tag.ToString ().Length - 1, 1);
			numCorretasLetras++;
			//verifica se a ultima letra e "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(other.gameObject.tag.ToString ().Substring (other.gameObject.tag.ToString ().Length - 1, 1))) {
				somCapturaCubos.Play ();
			}
			Debug.Log (cont);
		}
		
		if (numCorretasLetras >= numLetras){
			Debug.Log ("VOCE VENCEU");
		}
		
	}
}
