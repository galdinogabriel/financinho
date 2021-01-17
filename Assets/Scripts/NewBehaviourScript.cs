using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject InputField;
    private int numDialog = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(numDialog == 0){
            InputField.SetActive(false);
        numDialog = 1;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para alterar conteudo do objeto Text
	public void AtivarTextBox(){
		//Verificando a variavel numDialog e alterando o texto de dialogo conforme a ordem certa.
		if(numDialog == 1){
			InputField.SetActive(true);
			
		}
    }
    
}
