using UnityEditorInternal;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enermyTarget;
    public GameObject powerupTarget;
    public int enemyCount;
    private float spawnRange = 9f;
    private int enemyWave = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
        Debug.Log(enemyCount);
        if (enemyCount == 0){
            Spawn(enemyWave);
            enemyWave ++;
        }
    }

    void Spawn(int waveCount){
        for (int i = 0; i < waveCount; i++){
            Instantiate(enermyTarget, SpawnPositionGeneration(), enermyTarget.transform.rotation);
            Instantiate(powerupTarget, SpawnPositionGeneration(), enermyTarget.transform.rotation);
        }
    }

    private Vector3 SpawnPositionGeneration(){
        float xRandom = Random.Range(-spawnRange, spawnRange);
        float zRandom = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(xRandom, 0, zRandom);
        return spawnPosition;
    }
}
