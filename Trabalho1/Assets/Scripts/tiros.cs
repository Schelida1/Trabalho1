using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiros : MonoBehaviour
{
    public GameObject[] weapons;

    private int currentweaponIndex = 0;

    public Rigidbody2D rigido;

    public GameObject shotarca;

    public Transform Locacion;

    public float velocidadenave; 
    public bool temLaserDuplo;

    private Vector2 teclasApertadas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Trocar arma quando a tecla 'Tab' for pressionada
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Desativa a arma atual
            weapons[currentweaponIndex].SetActive(false);

            // Incrementa o índice para alternar para a próxima arma
            currentweaponIndex++;

            // Se chegarmos ao final do array, voltamos para a primeira arma
            if (currentweaponIndex >= weapons.Length)
            {
                currentweaponIndex = 0;
            }

            // Ativa a nova arma
            weapons[currentweaponIndex].SetActive(true);
        }

        // Disparar a arma atual quando a tecla 'Space' for pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AtirarLaser();
        }
        
    }
    private void MovimentarJogador()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigido.velocity = teclasApertadas.normalized * velocidadenave;
    }
    private void AtirarLaser()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(temLaserDuplo == false)
            {
                Instantiate(weapons[currentweaponIndex], Locacion.position, Locacion.rotation);
            }
        }
    }
}
