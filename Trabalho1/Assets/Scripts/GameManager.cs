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


    private void Awake() // primeiro metodo a ser rodado 
    {
        //if (Instance == null)
        //{
            instance = this;
         //   DontDestroyOnLoad(transform);
       // }
        // else 
          //  Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        pontosagr = 0;
        textodepontuacao.text = "Pontuação: " + pontosagr;
        //LoadScene("MainMenu"); // Assim que o jogo iniciar aparecerá a função Menu
    }

    // Update is called once per frame
    void Update()
    {  
    }

   //public void LoadScene(string sceneName)
    //{
     //SceneManager.LoadScene(sceneName); 
    //}

   public void Aumentarpont(int ganharpont)
   {
       pontosagr += ganharpont;
       textodepontuacao.text = "Pontuação: " + pontosagr;
       
   }
}
