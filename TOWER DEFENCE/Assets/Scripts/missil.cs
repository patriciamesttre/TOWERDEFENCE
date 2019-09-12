using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missil : MonoBehaviour
{
    private float velocidade = 5f;

    private GameObject alvo;

    private void Start()
    {
        alvo = GameObject.Find("Inimigo");
    }
    // Update is called once per frame
    void Update()
    {
        Anda();
        AlteraDirecao();
    }

    private void AlteraDirecao()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 posicaodoalvo = alvo.transform.position;
        Vector3 direcaodoalvo = posicaodoalvo - posicaoAtual;
        transform.rotation = Quaternion.LookRotation(direcaodoalvo);
    }

    private void Anda()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
        transform.position = posicaoAtual + deslocamento;
    }
}
