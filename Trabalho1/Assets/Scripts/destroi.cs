using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroi : MonoBehaviour
{
    public float tempovida;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempovida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
