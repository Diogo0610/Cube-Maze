using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] _coinSpawner;
    [SerializeField] private GameObject _coinPrefab;

    int _lenght = 15;
    List<int> list = new List<int>();

    private void Start()
    {
        GenerateRandom();
        SpawnCoin();
    }
    void GenerateRandom()
    {
        for (int i = 0; i < _lenght; i++)
        {
            int Rand = Random.Range(0, 31);
            while (list.Contains(Rand))
            {
                Rand = Random.Range(0, 31);
            }
            list.Add(Rand);
            //print(list[i]);
        }
    }

    void SpawnCoin()
    {
        foreach (int i in list)
        {
            Instantiate(_coinPrefab, _coinSpawner[i]);
        }
    }
}
