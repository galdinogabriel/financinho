using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Text dialogo;
	private int numDialog = 0;
	public GameObject respostaM01P0101;
	public GameObject respostaM01P0102;
	public GameObject respostaM01P0103;
	public GameObject respostaM01P0201;
	public GameObject respostaM01P0202;
	public GameObject respostaM01P0203;
    public GameObject bttAvançar;
	//Metodo carregar cena
    public void LoadPergunta01(string name){
		if(numDialog == 15){
			
			//Carregar cena de acordo com seu nome
			SceneManager.LoadScene(name);
		}
		
	
	}
	public void LoadModulo01(string name){
		SceneManager.LoadScene(name);
		
	
	}

	//Metodo para alterar conteudo do objeto Text
	public void MudarTexto(){
		

	}
}