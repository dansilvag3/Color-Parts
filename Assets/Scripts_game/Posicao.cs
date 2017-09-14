using UnityEngine;
using System.Collections;

public class Posicao : MonoBehaviour {
	
 public float speed = 1;    //Velocidade que a nave se move
    private float timer = 0f;       //Duração até mudar de direção
    private Vector3 direcao;        //Direção que a nave segue

    public float zMinimo;      //Altura minima que a nave pode ir
    public float zMaximo;      //Altura máxima que a nave pode ir
    public float xMinimo;      //Altura minima que a nave pode ir
    public float xMaximo;      //Altura máxima que a nave pode ir

    void Update() {

        if (timer <= 0) {
            timer = 2f; //Mantem nessa posição por 2 segundos
            //Define a direção de forma aleatória
            direcao.x = Random.Range(-1f, 1f); //Retorna um valor aletório entre -1 e 1
            direcao.z = Random.Range(-1f, 1f); //Retorna um valor aletório entre -1 e 1
        }
        timer -= Time.deltaTime; //Faz a contagem regressiva

        //Move a nave
        transform.Translate(direcao * speed * Time.deltaTime); //Move a nave aleatória

        //Ajusta a altura
        var posicao = transform.position;

        //Maxima e minima altura em Y.
        posicao.z = Mathf.Clamp(posicao.z, zMinimo, zMaximo);

        //Maxima e minima posicao em X.
        posicao.x = Mathf.Clamp(posicao.x, xMinimo, xMaximo);

        transform.position = posicao; //Define a posição com a altura ajustada
    }
}
