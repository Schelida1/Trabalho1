using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour
{
    public int vidacoracao = 5;
    public Slider barravidajog;
    public GameObject escudojogador; 
    public int vidamaxjogador;

    public int vidaatual;
    public int vidamaxescudo;
    public int vidaatualescudo; 
    public int damage;

    public bool temescudo;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaatual = vidamaxjogador;
        barravidajog.maxValue = vidamaxjogador;
        barravidajog.value = vidaatual;
        
        GameController.instance.UpdateLives(vidacoracao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ativarescudo()
    {
        escudojogador.SetActive(true);  // Ativar o escudo
        temescudo = true; // ta dizendo que tem escudo e para ativar
    }

    public void machucarjog(int danoreceber)
    {
        if (temescudo == false)
        {
            vidaatual -= danoreceber;
            barravidajog.value = vidaatual;
            if (vidaatual<= 0)
            {
                Damage();
                
            }
        }
        else
        {
            vidaatualescudo -= danoreceber;
            if (vidaatualescudo <=0 )
            {
                escudojogador.SetActive(false);
                temescudo = false;
            }
        }
    }

    public void Damage()
    {
        vidacoracao -= 1 ;
        GameController.instance.UpdateLives(vidacoracao);
        if (vidacoracao <= 0 )
           
        {
            Debug.Log("Game Over");
        }
        else
        {
            vidaatual = vidamaxjogador;
            barravidajog.value = vidaatual;
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tilemap"))
        {
            PerderVidaCoracao();
        }
    }

    void PerderVidaCoracao() // TIRAR VIDA DO JOGADOR TODA VEZ QUE ELE ENCOSTA NO TILEMAP
    {
        vidacoracao--;
        GameController.instance.UpdateLives(vidacoracao);
    
        if (vidacoracao <= 0)
        {
            Debug.Log("Game Over");
            
        }
        else
        {
            vidaatual = vidamaxjogador;
            barravidajog.value = vidaatual;
        }
    }

   
}
