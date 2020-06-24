using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject barrel;
    public GameObject warlus;
    public GameObject ice;
    public GameObject tire;

    public float spawntime = 1;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawnbarrel = Instantiate(barrel);
        GameObject spawnice = Instantiate(ice);
        GameObject spawnwarlus = Instantiate(warlus);
        GameObject spawntire = Instantiate(tire);
    }

    // Update is called once per frame
    void Update()
    {
        spawnobject();
    }

    public void spawnobject()
    {
        if (time > spawntime)
        {
            GameObject spawnbarrel = Instantiate(barrel);
            GameObject spawnice = Instantiate(ice);
            GameObject spawnwarlus = Instantiate(warlus);
            GameObject spawntire = Instantiate(tire);
            time = 0;
        }

        time += Time.deltaTime;
    }
}
