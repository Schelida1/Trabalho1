using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig; 
    public float velonave; // Essa variavel diz qual a velocidade da nave

    private Vector2 comand; //pega as teclas apertadas 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update é uma vez por freime 
    void Update() 
    {
        movplayer();
    }

    private void movplayer()
    {
        comand = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rig.velocity = comand.normalized * velonave;
    }
}
