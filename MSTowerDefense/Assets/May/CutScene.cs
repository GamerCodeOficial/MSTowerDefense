using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour {

    public GameObject[] panels; // array com todos os painéis
    public int act; // Index(Número) do painel ativo agora


	// Use this for initialization
	void Start () {
        Reload();//Atualizar estados dos Paineis
	}
	
    private void Reload() { //Ativa o painel de index act e desativa os outros
        for (int i = 0; i < panels.Length; i++) //Loop que passa por todos os elementos do array
        {
            if (i == act) //Se esse for o que tem que ser ativo
            {
                panels[i].SetActive(true); //ativar o painel de index i
            }
            else //Se esse não for o que tem que ser ativo
            {
                panels[i].SetActive(false); //desativar o painel de index i
            }

        }
    }
    public void Next() { //Void Ativado pelo botão
        if (act >= panels.Length-1)//Se ainda existem paineis não vistos
        {
            //Continuar a vida. Fim da CutScene
        }
        else
        {
            act++; //Passar para o próximo painel
        }
        Reload(); //Reorganizar os paineis
    }
}
