using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserinimi : MonoBehaviour
{
    public float velocidadelaser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentarlaser();
    }

    private void Movimentarlaser()
    {
        transform.Translate(Vector3.up * velocidadelaser * Time.deltaTime);
    }
}
