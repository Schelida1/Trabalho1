using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navemae : MonoBehaviour
{
    public 
    public GameObject Lasermae;
    public Transform localdeDisparoo;
    
    public float velomae;
    public float tempomaxlaser;
    public float tempoatuallaser;

    // sistem de velocidade do laser
    public int vidamaxinimigo;
    public int vidaatualinimig;
    
    public int danoparadar;
    public int pontosparadar;
    public GameObject escudo;
    public bool Temescudoo;
    void Start()
    {
        vidaatualinimig = vidamaxinimigo;

    }
    

    // Update is called once per frame
    void Update()
    {
        movimen();
        Atirar();
    }
    private void movimen()
    {
        transform.Translate(Vector3.up * velomae * Time.deltaTime);
    }

    private void Atirar()
    {
        tempoatuallaser -= Time.deltaTime;
        if (tempoatuallaser <= 0)
        {
            float angulo = Random.Range(-90f, 90f);
                Instantiate(Lasermae, localdeDisparoo.position, Quaternion.Euler(0f,0f,angulo + 90));
                tempoatuallaser = tempomaxlaser;

        }
    }

    public void Machuinimig(int danoreceber)
    
    {
        vidaatualinimig -= danoreceber;
        if (vidaatualinimig <= 0)
        {
            GameManager.instance.Aumentarpont(pontosparadar);
            Destroy(this.gameObject);
        }
        
    }
}
