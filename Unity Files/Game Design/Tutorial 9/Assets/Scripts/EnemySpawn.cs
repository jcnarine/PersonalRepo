using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public int EnemySpawnAmount = 10;
    public float EnemyDelay = 5.0f;
    private float Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        Cooldown = Time.time + EnemyDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Cooldown && EnemySpawnAmount > 0) {
            Instantiate(Enemy, new Vector3(Random.Range(-40,40), transform.position.y, transform.position.z), transform.rotation);
            Cooldown = Time.time + EnemyDelay;
            EnemySpawnAmount -= 1;

            }
    }
}
