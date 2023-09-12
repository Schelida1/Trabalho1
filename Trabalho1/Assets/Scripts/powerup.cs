using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public bool itemescudo;

    public bool itemdoublaser;

    public bool itemvida;
    public int Vidaparadar;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (itemescudo == true)
            {
                other.gameObject.GetComponent<vida>().Ativarescudo();
            }

           // if (itemdoublaser == true)
          //  {
             //   other.gameObject.GetComponent<Player>().doublaser = false;
            //    other.gameObject.GetComponent<Player>().Tempoatuallaserduplo = other.gameObject.GetComponent<Player>().Tempomaxlaserduplo ;
            //    other.gameObject.GetComponent<Player>().doublaser = true;
          //  }

            if (itemvida == true)
            {
                other.gameObject.GetComponent<vida>().GanharVidas(Vidaparadar);
            }

            Destroy(this.gameObject);
        }
    }
        
}
