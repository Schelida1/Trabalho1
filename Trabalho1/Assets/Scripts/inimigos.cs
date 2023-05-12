using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    public float Velinimig;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimtinimig();
    }

    private void movimtinimig()
    {
        transform.Translate(Vector3.Down * Velinimig * Time.deltaTime);
    }
}
