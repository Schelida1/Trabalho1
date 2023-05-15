using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class inimigos : MonoBehaviour
{
    public float Velinimig; // variavel faz referência a velocidade do inimigo
    public GameObject laserinimigo; // variável faz referência a inimigo 
    public Transform localdodisparo; // variável faz referência ao local do disparo
    public float tempolasermáx;// faz referência ao tempo que de um disparo e outro
    public bool atiradorinim;
    public float tempoatual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimtinimig();
        if (atiradorinim == true)
        {
            Atirar();
        }
        
    }

    private void movimtinimig()
    {
        transform.Translate(Vector3.down * Velinimig * Time.deltaTime);
    }

    private void Atirar()
    {
        tempoatual -= Time.deltaTime;
        if (tempoatual<= 0)
        {
            Instantiate(laserinimigo, localdodisparo, Quaternion.Euler(0f,0f,90f));
            tempoatual = tempolasermáx;
        }
        
    }

    private void Instantiate(GameObject original, Transform position, Quaternion instantiateInWorldSpace)
    {
        throw new System.NotImplementedException();
    }

    // private void Instantiate(GameObject original, Transform position, Quaternion instantiateInWorldSpace)
    //{
    // throw new System.NotImplementedException();
    //}
}
