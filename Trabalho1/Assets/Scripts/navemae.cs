using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navemae : MonoBehaviour
{
    public GameObject Lasermae;
    public Transform LocaldeDiaparoo;
    public float velomae;
    public float tempomaxlaser;
    public float tempoatuallaser;

    // sistem de velocidade do laser
    public float Velocidadelaser;
    public int danoparadar;
    

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimen();
        Atirar();
    }
    private void movimen()
    {
     transform.Translate(Vector3.up * velomae * Time.deltaTime);
    }

    private void Atirar()
    {
        tempoatuallaser -= Time.deltaTime;
        if (tempoatuallaser <= 0)
        {
            Instantiate(Lasermae, LocaldeDiaparoo.position, Quaternion.Euler(0f,0f,0f));
            tempoatuallaser = tempomaxlaser;
        }
    }
   private void MovimentarLaser()
   {
            transform.Translate(Vector3.up * Velocidadelaser * Time.deltaTime);
   }
   public void OnTriggerEnter2D(Collider2D other) // diz qual o objeto que coliddiu e armazenar aqui
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<vida>().machucarjog(danoparadar);
            Destroy(this.gameObject);
        }
    } 
}
