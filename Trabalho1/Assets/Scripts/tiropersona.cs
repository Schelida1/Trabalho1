using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tiropersona : MonoBehaviour
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
        movimentlaser();
    }

    private void movimentlaser()
    {
        transform.Translate(Vector3.right * velocidadelaser * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            other.gameObject.GetComponent<inimi>().Machuinimig(danoparadar);
            Destroy(this.gameObject);
        }
    }
}
