using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimi : MonoBehaviour
{
    public GameObject laserdoinimigo;
    public Transform localdedisparo;
    
    public float Velocidadedoinimigo;

    public float tempomaximo;
    public int vidamaxinimig;
    public int vidaatualinimig;
    public int pontosparadar;

    public float tempoatual;
    public bool inimigoAtirador;
    // Start is called before the first frame update
    void Start()
    {
        vidaatualinimig = vidamaxinimig;
    }

    // Update is called once per frame
    void Update()
    {
        Movimentarinimigo();
        
        if (inimigoAtirador == true)
        {
            atirar();
        }
        
    }

    private void Movimentarinimigo()
    {
        transform.Translate(Vector3.down * Velocidadedoinimigo * Time.deltaTime);
    }

    private void atirar()
    {
        tempoatual -= Time.deltaTime;
        if (tempoatual <= 0)
        {
            Quaternion rotation60 = Quaternion.Euler(0f, 0f, 60f);
            Quaternion rotation120 = Quaternion.Euler(0f, 0f, 120f);
          //  Instantiate(laserdoinimigo, localdedisparo.position, Quaternion.Euler(0f, 0f, 90f));
            Instantiate(laserdoinimigo, localdedisparo.position, rotation60);
            Instantiate(laserdoinimigo, localdedisparo.position, rotation120);
            tempoatual = tempomaximo;
        }
    }

    public void Machuinimig(int danoreceber)
    {
        vidaatualinimig -= danoreceber;
        if (vidaatualinimig <= 0 )
        {
            GameManager.instance.Aumentarpont(pontosparadar);
            Destroy(this.gameObject);
        }
    }
}
