using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida : MonoBehaviour
{
    public int vidacoracao = 5;
    public GameObject escudojogador; 
    public int vidamaxjogador;

    public int vidaatual;
    public int vidamaxescudo; // vida máxima do escudo
    public int vidaatualescudo; //vida atual do escudo
    public int damage;

    public bool temescudo;
    // Start is called before the first frame update
    void Start()
    {
        vidaatual = vidamaxjogador;
        vidaatualescudo = vidamaxescudo;
      //  barravidajog.maxValue = vidamaxjogador; // sempre que iniciar o jogo a vida máxima da barra vai ser igual a vida do jogador
      ///  barravidajog.value = vidaatual;// pra come
        
        escudojogador.SetActive(false);
        temescudo = false;
        GameController.instance.UpdateLives(vidacoracao);
    }

    // Update is called once per frame
    void Update()
    {
     
        
    }
     
    public void Ativarescudo()
    {
        vidaatualescudo = vidamaxescudo;
        escudojogador.SetActive(true);  // Ativar o escudo
        temescudo = true; // ta dizendo que tem escudo e para ativar
    }

    public void GanharVidas(int Vidaparareceber)
    {
        if (vidaatual + Vidaparareceber <= vidamaxjogador)
        {
            vidaatual += Vidaparareceber;
            PlayerObserver.OnEnergyChanged(vidaatual);
        }
        else
        {
            vidaatual = vidamaxjogador;
            PlayerObserver.OnEnergyChanged(vidaatual);
        }

       // barravidajog.value = vidaatual;
    }

    public void machucarjog(int danoreceber) // desconto vida da barra do jogador 
    {
        if (temescudo == false)
        {
            vidaatual -= danoreceber;
            PlayerObserver.OnEnergyChanged(vidaatual);
          //  barravidajog.value = vidaatual; // aqui ele está acessando o valor representado no barra de vida de value, em questão do preenchimento
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
//                escudojogador.SetActive(false);
                temescudo = false;
                PlayerObserver.OnEnergyChanged(vidaatual);
            }
        }
    }

    public void Damage()
    {
        vidacoracao -= 1 ;
        GameController.instance.UpdateLives(vidacoracao); // atualiza a vida 
        PlayerObserver.OnEnergyChanged(vidaatual);
        if (vidacoracao <= 0 )
           
           
        {
            Debug.Log("Game Over");
            PlayerObserver.OnEnergyChanged(vidaatual);
        }
        else
        {
            vidaatual = vidamaxjogador;
        //    barravidajog.value = vidaatual;
              PlayerObserver.OnEnergyChanged(vidaatual);
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tilemap"))
        {
            PerderVidaCoracao();
            PlayerObserver.OnEnergyChanged(vidaatual);
        }
    }

    void PerderVidaCoracao() // TIRAR VIDA DO JOGADOR TODA VEZ QUE ELE ENCOSTA NO TILEMAP
    {
        vidacoracao--;
        GameController.instance.UpdateLives(vidacoracao);
    
        if (vidacoracao <= 0)
        {
            Debug.Log("Game Over");
            PlayerObserver.OnEnergyChanged(vidaatual);
            
        }
        else
        {
            vidaatual = vidamaxjogador;
     //       barravidajog.value = vidaatual;
            PlayerObserver.OnEnergyChanged(vidaatual);
        }
    }
}
