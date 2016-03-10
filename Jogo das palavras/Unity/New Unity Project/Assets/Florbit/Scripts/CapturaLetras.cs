//Autor; Thiago Nicola Cajuela Garcia
/*
 * script que coleta os cubos e identifica qual foi o cubo coletado e joga o valor no gui text
 */
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CapturaLetras : MonoBehaviour {
	public Text textLetraCapturada;
	public AudioSource somCapturaCubos;
	private int cont; //Contador,conta quantidade de cubos capturados
	
	void Start ()
	{
		somCapturaCubos = GetComponent<AudioSource>();
		cont = 0;
		textLetraCapturada.text = "";
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Vazio")) {
			//other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			textLetraCapturada.text = textLetraCapturada.text + "";//caso pegue o cubo vazio zera o conteudo
			cont ++;
			somCapturaCubos.Play ();
			Debug.Log (cont);
		} 
		//verifica se a Tag contem a palavra cube
		if (other.gameObject.tag.ToString ().Contains ("Cube") == true) {
			//other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			//Pega a ultima letra da TAG
			textLetraCapturada.text = textLetraCapturada.text + other.gameObject.tag.ToString ().Substring (other.gameObject.tag.ToString ().Length - 1, 1);
			cont++;
			//verifica se a ultima letra e "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
			if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(other.gameObject.tag.ToString ().Substring (other.gameObject.tag.ToString ().Length - 1, 1))) {
				somCapturaCubos.Play ();
			}
			Debug.Log (cont);
		}

		if (cont >= 5){
			Debug.Log ("VOCE VENCEU");
		}

	}
}