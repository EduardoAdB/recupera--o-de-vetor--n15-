using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int corDaVez;
    int acertos;
    int erros;

    int[] sequencia;

    [SerializeField]
    string[] nomes;


    private void Start()
    {
        GerarSequencia();
    }

    public void GerarSequencia()
    {
        corDaVez = 0;
        sequencia = new int[Random.Range(3, nomes.Length)];
        //UiManager.instance.LimparTexto();
        for (int i = 0; i < sequencia.Length; i++)
        {
            sequencia[i] = Random.Range(3, nomes.Length);
            //UiManager.instance.AtualizarSequencia(nomes[i]);
            //Att pra validar os comit
        }
    }
    
}
