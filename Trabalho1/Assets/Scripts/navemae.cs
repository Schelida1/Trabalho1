using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class navemae : MonoBehaviour
{

    public Slider barramae;
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
    public int vidamaxescudo;
    public int vidaatualescudo;
    void Start()
    {
        vidaatualinimig = vidamaxinimigo;
        barramae.maxValue = vidamaxinimigo;
        barramae.value = vidaatualinimig;

        escudo.SetActive(true);
        Temescudoo = true;
        AtivarEscudo();
        

    }
    public void AtivarEscudo()
    {
        vidaatualescudo = vidamaxescudo;

        escudo.SetActive(true);
        Temescudoo = true;

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
    
    {   if(Temescudoo == false)
          {
               vidaatualinimig -= danoreceber;
               barramae.value = vidaatualinimig;

               if (vidaatualinimig <= 0)
                  {
                       GameManager.instance.Aumentarpont(pontosparadar);
                       Destroy(this.gameObject);
                  }

          }
         else
         {
               vidaatualescudo -= danoreceber;
               if( vidaatualescudo <= 0 )
                  {
                       escudo.SetActive(false);
                       Temescudoo = false;
                  }


         }

      
        
    }
}
