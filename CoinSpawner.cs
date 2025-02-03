using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float timeToSpawn;
    private void Start()
    {
        StartCoroutine(_CoinSpawner());
    }
    private void CoinSpawn()
    {
        GameObject coin = Instantiate(coinPrefab);
        coin.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
    }

    IEnumerator _CoinSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            CoinSpawn();
        }
    }
}