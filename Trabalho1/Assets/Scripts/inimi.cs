using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimi : MonoBehaviour
{
    public GameObject laserdoinimigo;
    public Transform localdedisparo;
    
    public float Velocidadedoinimigo;

    public float tempomaximo;

    public float tempoatual;
    public bool inimigoAtirador;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
            Instantiate(laserdoinimigo, localdedisparo.position, Quaternion.Euler(0f, 0f, 90f));
            tempoatual = tempomaximo;
        }
    }
}
