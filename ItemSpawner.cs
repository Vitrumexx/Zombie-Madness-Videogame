using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int ItemsCount;
    [SerializeField] private GameObject itemPrefab;
    private int count = 0;
    private void Start()
    {
        StartCoroutine(_ItemSpawner());
    }
    private void ItemSpawn()
    {
        GameObject item = Instantiate(itemPrefab);
        item.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
    }

    IEnumerator _ItemSpawner()
    {
        while (count < ItemsCount)
        {
            yield return new WaitForSeconds(0);
            ItemSpawn();
            count++;
        }
    }
}
