using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geraobj : MonoBehaviour
{
    public GameObject[] objparaSpawnar;

    public Transform[] pontosSpawn;

    public float tempomaxspawns;

    public float atualspawns;
    // Start is called before the first frame update
    void Start()
    {
        atualspawns = tempomaxspawns;
    }

    // Update is called once per frame
    void Update()
    {
        atualspawns -= Time.deltaTime;
        if (atualspawns <= 0)
        {
            Spawnarobj();
        }
    }

    private void Spawnarobj()
    {
        int objaleatorio = Random.Range(0, objparaSpawnar.Length);
        int pontoaleatorio = Random.Range(0, pontosSpawn.Length);

        Instantiate(objparaSpawnar[objaleatorio], pontosSpawn[pontoaleatorio].position, Quaternion.Euler(0F, 0F, -90F));
        atualspawns = tempomaxspawns;
    }
}
