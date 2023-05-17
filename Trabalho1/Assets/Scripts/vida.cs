using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
    public int vidamaxjogador;

    public int vidaatual;

    public bool temescudo;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaatual = vidamaxjogador;
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
            if (vidaatual<= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
    
}
