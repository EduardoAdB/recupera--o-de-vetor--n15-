using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    #region.singleton
    [SerializeField]
    Button[] botoes;
    [SerializeField]
    TextMeshProUGUI sequenciaTexto;
    [SerializeField]
    TextMeshProUGUI acertouTexto;
    [SerializeField]
    TextMeshProUGUI errouTexto;

    public static UiManager instance;
    #endregion

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        
        for (int i = 0; i < botoes.Length; i++) 
        {
            int x = i;
            botoes[i].onClick.AddListener(() => GameManager.instance.ChecarCor(x));
           
        }
    } 
    //botões não estão alterando a sequencia de cores
    public void AtualizarAcertos(int acertos)
    {
        acertouTexto.text ="acertos: "+ acertos.ToString(); //o string não está sendo alterado
    }
    public void AtualizarErros(int erros)
    {
        errouTexto.text ="erros: "+ erros.ToString(); //o string não está sendo alterado
    }
    public void LimparTexto()
    {
        sequenciaTexto.text = string.Empty;
    }

    public void AtualizarSequencia(string cor)
    {
        sequenciaTexto.text += cor+" ";
    }


}
