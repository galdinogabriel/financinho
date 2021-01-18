using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class perguntas : MonoBehaviour
{

    
	private int numDialog = 0;
	
	public GameObject respostaM01P0101;
	public GameObject respostaM01P0102;
	public GameObject respostaM01P0103;

	public GameObject respostaM01P0201;
	public GameObject respostaM01P0202;
	public GameObject respostaM01P0203;

	public GameObject respostaM01P0301;
	public GameObject respostaM01P0302;
	public GameObject respostaM01P0303;
    public GameObject bttAvançar;
	//Metodo carregar cena
    
	

	public void LoadModulo01(string name){
		SceneManager.LoadScene(name);
		
	
	}

	//Metodo para verificar pergunta 1
	public void VerificarPergunta(){
		numDialog = 1;
		if(numDialog == 1){
			// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(-10f, -843f, 0f);
		// move as perguntas 1 para fora da tela
        respostaM01P0101.transform.localPosition = new Vector3(964f, 564f, 0f);
		respostaM01P0102.transform.localPosition = new Vector3(964f, 418f, 0f);
		respostaM01P0103.transform.localPosition = new Vector3(964f, 268f, 0f);
		//
		GameObject.Find("txtPergunta").GetComponentInChildren<Text>().text = "Parabéns, você acertou, é exatamente isso!";
		
		}
	}
	//Metodo para verificar pergunta 2
	public void VerificarPergunta2(){
		numDialog = 2;
		if(numDialog == 2){
			// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(-10f, -843f, 0f);
		// move as perguntas 1 para fora da tela
        respostaM01P0201.transform.localPosition = new Vector3(964f, 564f, 0f);
		respostaM01P0202.transform.localPosition = new Vector3(964f, 418f, 0f);
		respostaM01P0203.transform.localPosition = new Vector3(964f, 268f, 0f);
		//
		GameObject.Find("txtPergunta").GetComponentInChildren<Text>().text = "Parabéns, você acertou, é exatamente isso!";
		
		}	
		
	}
	public void VerificarPergunta3(){
		numDialog = 3;
		if(numDialog == 3){
			// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(-10f, -843f, 0f);
		// move as perguntas 1 para fora da tela
        respostaM01P0301.transform.localPosition = new Vector3(964f, 564f, 0f);
		respostaM01P0302.transform.localPosition = new Vector3(964f, 418f, 0f);
		respostaM01P0303.transform.localPosition = new Vector3(964f, 268f, 0f);
		//
		GameObject.Find("txtPergunta").GetComponentInChildren<Text>().text = "Parabéns, você acertou, é exatamente isso!";
		
		}	
		
	}
	public void MudarPergunta(string name){
		if(numDialog == 1){
			// move as perguntas 1 para fora da tela
        respostaM01P0201.transform.localPosition = new Vector3(0f, 564f, 0f);
		respostaM01P0202.transform.localPosition = new Vector3(0f, 418f, 0f);
		respostaM01P0203.transform.localPosition = new Vector3(0f, 268f, 0f);
		// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(964f, -843f, 0f);
		GameObject.Find("txtPergunta").GetComponentInChildren<Text>().text = "Qual é o maior valor do Papel-moeda brasileiro?";
		
		}else
		if(numDialog == 2){
			// move as perguntas 2 para fora da tela
        // move as perguntas 1 para fora da tela
        respostaM01P0301.transform.localPosition = new Vector3(0f, 564f, 0f);
		respostaM01P0302.transform.localPosition = new Vector3(0f, 418f, 0f);
		respostaM01P0303.transform.localPosition = new Vector3(0f, 268f, 0f);
		// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(964f, -843f, 0f);
		GameObject.Find("txtPergunta").GetComponentInChildren<Text>().text = "Qual os animais que tem nos Papeis-moeda Brasileiro?";

		
		}else
		if(numDialog == 3){
		
		// move as perguntas 2 para a tela
        bttAvançar.transform.localPosition = new Vector3(964f, -843f, 0f);
			SceneManager.LoadScene(name);
		
		}

		
	}


}

