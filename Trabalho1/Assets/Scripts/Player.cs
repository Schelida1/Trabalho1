using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    public GameObject tiroperson;
    public Transform localdisparounic;
    
    public float velonave; // Essa variavel diz qual a velocidade da nave
    public bool doublaser;
    private Vector2 comand; //pega as teclas apertadas 
    // Start is called before the first frame update
    void Start()
    {
        doublaser = false;
    }

    // Update é uma vez por freime 
    void Update() 
    {
        movplayer();
        Atirar();
        
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
                Instantiate(tiroperson, localdisparounic.position, localdisparounic.rotation);
            }
        }
    }
}
