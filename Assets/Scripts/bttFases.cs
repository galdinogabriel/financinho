using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bttFases : MonoBehaviour
{
	public Text dialogo;
	private int numDialog = 0;
	//Metodo carregar cena
	public void LoadPergunta01(string name){
		if(numDialog == 10){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			//Carregar cena de acordo com seu nome
			numDialog = 11;
			SceneManager.LoadScene(name);
		}
		
	
	}
	public void LoadModulo01(string name){
		SceneManager.LoadScene(name);
	
	}

	//Metodo para alterar conteudo do objeto Text
	public void MudarTexto(){
		//Verificando a variavel numDialog e alterando o texto de dialogo conforme a ordem certa.
		if(numDialog == 0){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Meu nome é Geraldo.";
			numDialog = 1;
		}else
		if(numDialog == 1){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Eu estou aqui para lhe guiar nesse aprendizado.";
			numDialog = 2;
		}else
		if(numDialog == 2){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Antes de tudo eu preciso ensinar a você o que é dinheiro!";
			numDialog = 3;
		}else
		if(numDialog == 3){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Olha só aqui em cima no quadro uma explicação sobre. (Aperte em avançar!)";
			numDialog = 4;
		}else
		if(numDialog == 4){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			//Alterando o texto de do quadro.
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "A gente chama de dinheiro a forma aceita e controlada pelo governo do nosso país, servindo para comprar as coisas: bens, serviços, pagar dividas etc.";
			numDialog = 5;
		}else
		if(numDialog == 5){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "Os exemplos de dinheiro são: moedas, papel-moeda (5 reias, 10 reais), cheques, depósitos de pupanças etc.";
			numDialog = 6;
		}else
		if(numDialog == 6){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Você precisa entender o valor do dinheiro, ele possui 2 tipos. Olhe o quadro a cima. (aperte em avançar!)";
			numDialog = 7;
		}else
		if(numDialog == 7){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "O primeiro é o valor absoluto por exemplo, 100 reais tem o mesmo valor tanto para uma pessoa rica quanto pobre, e o valor relativo que 100 reais para um pobre vale muito e para um rico não vale tanto por ele ter mais.";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			numDialog = 8;
		}else
		if(numDialog == 8){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Eai, que tal se eu te fizesse uma pergunta para saber se você esta prestando atenção?";
			numDialog = 9;
		}else
		if(numDialog == 9){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Você lembra quais são os exemplos de dinheiro?";
			numDialog = 10;
		}else
		if(numDialog == 10){
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			//Carregar cena de acordo com seu nome
			numDialog = 11;
			LoadPergunta01(name);
		}
		
		
	}

}
