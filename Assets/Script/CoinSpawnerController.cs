using System.Runtime.CompilerServices;
using UnityEngine;

public class CoinSpawnerController: MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;

    private Vector3 pos;

    public GameObject coinPrefub;
    private float spawnTime = 0f;
    [SerializeField] private float spawnCooldown;

    private void Update()
    {
        Move();
        Spawn();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");

        pos = transform.position;
        pos.x += x * speed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -11.5f, 7.5f); //(pos.x, ¶”ÍˆÍ§ŒÀ, ‰E”ÍˆÍ§ŒÀ)
        transform.position = pos;
    }

    private void Spawn()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= spawnCooldown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(coinPrefub, transform.position, Quaternion.identity);

                spawnTime = 0f;
            }
        }       
    }
}
