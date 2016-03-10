using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GeraFrase : MonoBehaviour {
	//QUANTIDADE DE FRASES
	string[] letrasFaze1 = {"AAAAA","BBBBB","CCCCC","DDDDD","EEEEE","FFFFF","GGGGG","HHHHH","IIIII","JJJJJ","KKKKK","WWWWW","XXXXX",
							"LLLLL","MMMMM","NNNNN","OOOOO","PPPPP","QQQQQ","RRRRR","SSSSS","TTTTT","UUUUU","VVVVV","YYYYY","ZZZZZ"};
	//VARIAVEL FRASE DO TIPO PUBLICA PERMITINDO EXPANÇAO DO ARQUIVO
	public string letraEscolhida = "";
	public Text textLetrasGeradas;	
	// PEGA OS VALORES DA VARIALVE TEXT E JOGA EM Text

	void Awake () {
		textLetrasGeradas = GetComponent <Text> ();	
	}

	void Update () {
	}
	//FUNÇAO START ESTA COMO PUBLICA PARRA SER ENCONTRADA NO EVENDO BUTTON
	public void Start () {
		//VERIFICA O TAMANHO DO VETOR E CAPTURA A QUANTIDADE DE FRASES E JOGA EM (quantFrases)
		int quantFrases = letrasFaze1.Length;

		//FAZ O SORTEIRO DE 0 A quantFrases e JOGA A POSIÇAO SORTEADA EM NFRASES
		int nposition = Random.Range(0, quantFrases);
		letraEscolhida = letrasFaze1 [nposition];
		textLetrasGeradas.text = letraEscolhida;
		//Debug.Log ("QUANTIDADE DE LETRAS = "+quantFrases);
		//Debug.Log ("LETRA ESCOLHIDA" + nposition);
	}
}
