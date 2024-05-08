using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{ 
    private Transform bar;
    public static float sizeNormalized = 1f;

    private void Start()
    {
        bar = transform.Find("Bar");
        sizeNormalized = 1f;
    }

    public void Update()
    {
        SetSize();
    }

    public void SetSize ()
    {
        if (sizeNormalized >= 0) // necessário para a barra não sair dos limites e "andar para trás"
        {
            bar.localScale = new Vector3(sizeNormalized, 1f);
        }
        else
        {
            bar.localScale = new Vector3(0f, 1f);
            //caso o último dano recebido deixe a vida negativa, a barra não irá atualizar e seu tamanho corresponderá à última atualização
        }
    }
}
