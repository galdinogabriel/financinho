using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cofrinho : MonoBehaviour
{
	
	
    private double totalCofre = 0;
	
	//Metodo carregar cena
	public void LoadModulo01(string name){
		SceneManager.LoadScene(name);
	
	}

	public void Add10Centavos(){
		
			totalCofre = totalCofre + 0.10;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add25Centavos(){
		
			totalCofre = totalCofre + 0.25;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add50Centavos(){
		
			totalCofre = totalCofre + 0.50;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add75Centavos(){
		
			totalCofre = totalCofre + 0.75;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add1Real(){
		
			totalCofre = totalCofre + 1;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add5Reais(){
		
			totalCofre = totalCofre + 5;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add10Reais(){
		
			totalCofre = totalCofre + 10;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add50Reais(){
		
			totalCofre = totalCofre + 50;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	public void Add100Reais(){
		
			totalCofre = totalCofre + 100;
			GameObject.Find("txtTotalCofre").GetComponentInChildren<Text>().text = "R$"+totalCofre.ToString();
		
	}
	

}
