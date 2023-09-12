using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    public GameObject tiroperson;
    public Transform localdisparounic;
    public Transform localdisparoEsquerda;
    public Transform localdisparoDireita;

    public float Tempomaxlaserduplo;
    public float Tempoatuallaserduplo;


     
    
    public float velonave; // Essa variavel diz qual a velocidade da nave
    public bool doublaser;
    private Vector2 comand; //pega as teclas apertadas 
    // Start is called before the first frame update
    void Start()
    {
        doublaser = false; 
        Tempoatuallaserduplo = Tempomaxlaserduplo;
    }

    // Update é uma vez por freime 
    void Update() 
    {
        movplayer();
        Atirar();
        
        if(doublaser == true)
        {
             Tempoatuallaserduplo  -=  Time.deltaTime;

             if(Tempoatuallaserduplo <= 0)
            {
                  Desativadoublaser();
             }
        }


       
    }


    private void movplayer()
    {
        comand = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rig.velocity = comand.normalized * velonave;
    }

    private void Atirar ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
              if (doublaser == false)
              {
                    Instantiate(tiroperson, localdisparounic.position, Quaternion.identity);
              }
              else 
              {
                  Instantiate(tiroperson, localdisparoEsquerda.position, Quaternion.identity);
                  Instantiate(tiroperson, localdisparoDireita.position, Quaternion.identity);
              }

        }
    }

    private void Desativadoublaser()
    {
      doublaser = false; 
      Tempoatuallaserduplo = Tempomaxlaserduplo;
    }
}
