using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vida : MonoBehaviour
{
    public Slider barravidajog; 
    public int vidamaxjogador;

    public int vidaatual;

    public bool temescudo;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaatual = vidamaxjogador;
        barravidajog.maxValue = vidamaxjogador;
        barravidajog.value = vidaatual;
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
                Debug.Log("Game Over");
            }
        }
    }
    
}
