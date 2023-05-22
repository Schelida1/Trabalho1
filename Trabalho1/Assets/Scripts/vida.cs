using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour
{
    public int vidacoracao = 5 ;
    public Slider barravidajog; 
    public int vidamaxjogador;

    public int vidaatual;
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

   
}
