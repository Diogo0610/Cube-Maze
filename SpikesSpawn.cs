using System.Collections.Generic;
using UnityEngine;

public class SpikesSpawn : MonoBehaviour
{
    public Transform[] spikesPositions;
    public GameObject spike;

    int _lenght = 38;
    List<int> list = new List<int>();

    private void Start()
    {
        GenerateRandom();
        SpawnSpike();
    }
    void GenerateRandom()
    {
        for (int i = 0; i < _lenght; i++)
        {
            int Rand = Random.Range(0, 55);
            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, 55);
            }
            list.Add(Rand);
            //print(list[i]);
        }
    }

    void SpawnSpike()
    {
        foreach (int i in list)
        {
            Instantiate(spike, spikesPositions[i]);
        }
    }
}
