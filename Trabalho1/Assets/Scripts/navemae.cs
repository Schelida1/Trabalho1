using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navemae : MonoBehaviour
{
public float velomae;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimen();
    }
    private void movimen()
    {
     transform.Translate(Vector3.down * velomae * Time.deltaTime);
    }
}
