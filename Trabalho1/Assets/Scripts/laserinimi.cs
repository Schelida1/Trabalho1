using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class laserinimi : MonoBehaviour
{
    public float velocidadelaser;

    public int danoparadar;
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

    void Ontrigger2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<vida>().machucarjog(danoparadar);
        }
    }
   //private  void OnCollisionEnter2D(Collider2D other) // diz qual o objeto que coliddiu e armazenar aqui
  //  {
    ///    if (other.gameObject.CompareTag("Player"))
     //   {
     //       other.gameObject.GetComponent<vida>().machucarjog(danoparadar);
            
  //      }
 //   } 
    
    
    
    void OnTriggerEnter2D(Collider2D other) // diz qual o objeto que coliddiu e armazenar aqui
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<vida>().machucarjog(danoparadar);
            Destroy(this.gameObject);
        }
    } 
}
