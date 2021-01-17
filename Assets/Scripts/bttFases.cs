using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bttFases : MonoBehaviour
{
	public Text dialogo;
	private int numDialog = 0;
	public GameObject avatar001;
	public GameObject avatar002;
	public GameObject avatar003;
	public GameObject avatar004;
	public GameObject avatarCantoTela;
	public GameObject simbolos_moedas;
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
		//Verificando a variavel numDialog e alterando o texto de dialogo conforme a ordem certa.
		if(numDialog == 0){
		// Move the object to the same position as the parent:
        avatar001.transform.localPosition = new Vector3(2.88f, -1.29f, -2f);
		avatarCantoTela.transform.localPosition = new Vector3(7f, -1.69f, -1f);
		//
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Meu nome é Lucas";
			numDialog = 1;
		}else
		if(numDialog == 1){
			// Move the object to the same position as the parent:
        avatar001.transform.localPosition = new Vector3(-2.86f, -1.29f, -2f);
		avatar002.transform.localPosition = new Vector3(3.35f, -1.36f, -2f);
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Eu estou aqui para lhe guiar nesse aprendizado.";
			numDialog = 2;
		}else
		if(numDialog == 2){
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Antes de tudo eu preciso ensinar a você o que é dinheiro!";
			numDialog = 3;
		}else
		if(numDialog == 3){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(6.47f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(3.21f, -1.57f, -2f);
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Olha só aqui em cima no quadro uma explicação sobre. (Aperte em avançar!)";
			numDialog = 4;
		}else
		if(numDialog == 4){
		// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(1.84f,-1.67f,-2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
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
				// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(6.47f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(3.21f, -1.57f, -2f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Você precisa entender o valor do dinheiro, ele possui 2 tipos. Olhe o quadro a cima. (aperte em avançar!)";
			numDialog = 7;
		}else
		if(numDialog == 7){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(1.84f,-1.67f,-2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "O primeiro é o valor absoluto por exemplo, 100 reais tem o mesmo valor tanto para uma pessoa rica quanto pobre, e o valor relativo que 100 reais para um pobre vale muito e para um rico não vale tanto por ele ter mais.";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			numDialog = 8;
		}else
		if(numDialog == 8){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(1.84f,-1.67f,-2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "No Brasil temos 7 valores de notas de dinheiro (papel-moeda), a nota de 2 reais, 5 reais, 20 reais, 50 reais, 100 reais e a mais nova a nota de 200 reais que foi criada em 2020.";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			numDialog = 9;
		}
		else
		if(numDialog == 9){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(3.35f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Antigamente tinhamos a nota de 1 real, mas hoje em dia ela não é mais fabricada e não pode ser utilizada.";
			numDialog = 10;
		}else
		if(numDialog == 10){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(3.35f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "Cada pais tem um simbolo que representa o seu dinheiro.";
			numDialog = 11;
		}
		else
		if(numDialog == 11){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(6.47f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(3.21f, -1.57f, -2f);
		simbolos_moedas.transform.localPosition = new Vector3(1.76f,2.19f,-1);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "aqui estão alguns deles.";
			numDialog = 12;
		}
		else
		if(numDialog == 12){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(3.35f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
		simbolos_moedas.transform.localPosition = new Vector3(6.72f,2.54f,-1f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "além do simbolo, no brasil cada valor possui um animal que representa esse valor.";
			numDialog = 13;
		}
		else
		if(numDialog == 13){
			// Move the object to the same position as the parent:
        avatar002.transform.localPosition = new Vector3(3.35f, -1.36f, -2f);
		avatar003.transform.localPosition = new Vector3(8.98f, -1.61f, -2f);
		simbolos_moedas.transform.localPosition = new Vector3(6.72f,2.54f,-1f);
			GameObject.Find("txtQuadro").GetComponentInChildren<Text>().text = "São eles: Tartaruga de pente (2 reais), Garça (5 reais), Arara (10reais), Mico-leão-dourado (20 reais), Onça Pintada (50 reais), Garoupa (100 reais), Lobo-guará (200 reais).";
			GameObject.Find("txtDialog").GetComponentInChildren<Text>().text = "";
			numDialog = 14;
		}else
		if(numDialog == 14){
			
			numDialog = 15;
			LoadPergunta01(name);
		}
		
		
	}

}
