using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enermyTarget;
    private float spawnRange = 9f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("EnermySpawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnermySpawn(){
        Instantiate(enermyTarget, SpawnPositionGeneration(), enermyTarget.transform.rotation);
    }

    private Vector3 SpawnPositionGeneration(){
        float xRandom = Random.Range(-spawnRange, spawnRange);
        float zRandom = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(xRandom, 0, xRandom);
        return spawnPosition;
    }
}
