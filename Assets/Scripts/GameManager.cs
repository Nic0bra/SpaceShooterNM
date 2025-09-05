using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    //[SerializeField] public float spawnTime = 2f;
    [SerializeField] public GameObject enemyShip;
    public float ySpawnPos = 15;

    //public bool isGamePlaying;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //isGamePlaying = true;
        //StartCoroutine(SpawnShip());
        InvokeRepeating("SpawnShip", 2f, 2f);
    }
    /*IEnumerator SpawnShip()
    {
        while (isGamePlaying)
        {
            float spawnPosition = Random.Range(-3.73f, 3.73f);
            Instantiate(enemyShip, new Vector3(spawnPosition, 12f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }*/

    void SpawnShip()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-3.73f, 3.73f), ySpawnPos, 0);
        Instantiate(enemyShip, spawnPosition, Quaternion.identity);
    }
}
