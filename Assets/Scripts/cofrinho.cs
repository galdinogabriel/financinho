using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cofrinho : MonoBehaviour
{
	
	
    //private double totalCofre = 0;
	public double valor;
	public GameObject inputField;
	public GameObject textDisplay;
	//Metodo carregar cena
	public void LoadModulo01(string name){
		SceneManager.LoadScene(name);
	
	}

	public void MudarValorTotal(){
		valor += double.Parse(inputField.GetComponent<Text>().text);
		textDisplay.GetComponent<Text>().text = "R$"+valor.ToString();
	}
	

}
