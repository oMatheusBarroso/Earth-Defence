using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    private float _rapidez = 10.0f;

    void Update()
    {
        transform.Rotate(new Vector3(x: 0, y: 0, z: 0));
        Rotate(0, 0, Input.GetAxisRaw("Horizontal"));
    }

    void Rotate(float x, float y, float z)
    {
        var playerInput = new Vector3(x, y, z);
        var direcao = playerInput.normalized;
        var velocidade = _rapidez * direcao;
        var qntMovimento = velocidade * Time.deltaTime;

        transform.Rotate(-qntMovimento);
        // "-" para rotacionar no sentido horário ao pressionar para a direita, o sentido normal faz com que rotacione para a esquerda, ficando invertido
    }
}
