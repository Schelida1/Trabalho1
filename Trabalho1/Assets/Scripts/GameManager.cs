using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text textodepontuacao;
    public int pontosagr;


    //private void OnDisable()
    //{
     //   PlayObserverManeger.OnPlayer NotImplementedException();
   // }

    private void Awake() // primeiro metodo a ser rodado 
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //pontosagr = 0;
        //textodepontuacao.text = "Pontuação: " + pontosagr;
        //LoadScene("MainMenu"); // Assim que o jogo iniciar aparecerá a função Menu
        SceneManager.LoadScene( "MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

   
    public void LoadScene(string MainMenu)
    {
     SceneManager.LoadScene(MainMenu); 
    }

   public void Aumentarpont(int ganharpont)
   {
       pontosagr += ganharpont;
       textodepontuacao.text = "Pontuação: " + pontosagr;
       
   }

   public void LoadLevel( )
   {
       SceneManager.LoadScene("Level1");
       SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
   }
}
