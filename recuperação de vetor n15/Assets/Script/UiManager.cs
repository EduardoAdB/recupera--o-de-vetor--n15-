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
    Button[] botoes;
    [SerializeField]
    TextMeshProUGUI sequenciaTexto;
    [SerializeField]
    TextMeshProUGUI acertouTexto;
    [SerializeField]
    TextMeshProUGUI errouTexto;
    #endregion
    private void Start()
    {
        for (int i = 0; i < botoes.Length; i++)
        {
            int x = i;
            //botoes[i].onClick(GameManager.ChecarCor(x));
        }
    }
    public void AtualizarAcertos(int acertos)
    {
        acertouTexto.text = acertos.ToString();
    }
    public void AtualizarErros(int erros)
    {
        errouTexto.text = erros.ToString();
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
