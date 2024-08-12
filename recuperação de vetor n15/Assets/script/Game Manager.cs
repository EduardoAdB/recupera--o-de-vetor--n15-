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
    public static GameManager instance;

    [SerializeField]
    string[] nomes;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GerarSequencia();
    }

    public void GerarSequencia()
    {
        corDaVez = 0;
        sequencia = new int[Random.Range(3, nomes.Length)]; //os nomes não são aleatórios, acredito que tenha erros no começo do array;
        UiManager.instance.LimparTexto();
        for (int i = 0; i < sequencia.Length; i++)
        {
            sequencia[i] = Random.Range(0, nomes.Length);
            UiManager.instance.AtualizarSequencia(nomes[i]);    
        }
    }
    public void ChecarCor(int corIndex)
    {
        if (corIndex == sequencia[corDaVez])
        {
            corIndex += corDaVez;
            if (corDaVez == sequencia.Length)
            {
                acertos++;
                UiManager.instance.AtualizarAcertos(acertos);
                GerarSequencia();
            }
        }
        else
        {
            erros++;
            UiManager.instance.AtualizarErros(erros); 
            GerarSequencia();
        }

    }
}
