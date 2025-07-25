using UnityEngine;

public class CoinSpawnerController : MonoBehaviour
{
    [Header("スポナー設定")]

    // === 参照オブジェクト ===
    [SerializeField] CoinCountManager coinCountManager;
    [SerializeField] private CoinPool coinPool;

    // === パラメーター ===
    [SerializeField,Tooltip("左右に動く速さ")] private float moveSpeed = 1.0f;
    [SerializeField] private float spawnCooldown;
    [SerializeField, Tooltip("生成時の下方向の力")] private float forceAmount = 1.0f;

    // === 状態変数 ===
    private Vector3 pos;
    private float spawnTime = 0f;

    private void Update()
    {
        Move();
        Spawn();
    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");

        pos = transform.position;
        pos.x += x * moveSpeed * Time.deltaTime;
        pos.x = Mathf.Clamp(pos.x, -11.5f, 7.5f); //(pos.x, 左範囲制限, 右範囲制限)
        transform.position = pos;
    }

    public void Spawn()
    {
        spawnTime += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && spawnTime >= spawnCooldown)
        {
            if (coinCountManager.UseCoin())
            {
                GameObject coin = coinPool.GetCoin();
                coin.transform.position = transform.position;
                coin.transform.rotation = Quaternion.Euler(90f, 0f, 0f);

                Rigidbody rb = coin.GetComponent<Rigidbody>();
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.AddForce(Vector3.down * forceAmount, ForceMode.Impulse);

                spawnTime = 0f;
            }
            else
            {
                Debug.Log("コインないよ");
            }
        }
    }
}
