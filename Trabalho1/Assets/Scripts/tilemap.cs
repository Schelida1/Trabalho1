using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemap : MonoBehaviour
{
    public int danoparadar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collider2D other) // diz qual o objeto que coliddiu e armazenar aqui
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<vida>().machucarjog(danoparadar);
        }
    } 
}
