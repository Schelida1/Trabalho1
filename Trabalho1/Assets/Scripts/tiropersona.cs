using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tiropersona : MonoBehaviour
{
    public float velocidadelaser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentlaser();
    }

    private void movimentlaser()
    {
        transform.Translate(Vector3.up * velocidadelaser * Time.deltaTime);
    }
}
