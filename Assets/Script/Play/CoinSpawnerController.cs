using UnityEngine;

public class CoinSpawnerController : MonoBehaviour
{
    [Header("�X�|�i�[�ݒ�")]

    // === �Q�ƃI�u�W�F�N�g ===
    [SerializeField] CoinCountManager coinCountManager;
    [SerializeField] GameObject coinPrefub;

    // === �p�����[�^�[ ===
    [SerializeField,Tooltip("���E�ɓ�������")] private float moveSpeed = 1.0f;
    [SerializeField] private float spawnCooldown;
    [SerializeField, Tooltip("�������̉������̗�")] private float forceAmount = 1.0f;

    // === ��ԕϐ� ===
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
        pos.x = Mathf.Clamp(pos.x, -11.5f, 7.5f); //(pos.x, ���͈͐���, �E�͈͐���)
        transform.position = pos;
    }

    public void Spawn()
    {
        spawnTime += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && spawnTime >= spawnCooldown)
        {
            if (coinCountManager.UseCoin())
            {
                // ����
                Quaternion rotation = Quaternion.Euler(90f, 0f, 0f);
                GameObject coin = Instantiate(coinPrefub, transform.position, rotation);

                // �������ɗ͂�������
                Rigidbody rb = coin.GetComponent<Rigidbody>();
                rb.AddForce(Vector3.down * forceAmount, ForceMode.Impulse);

                spawnTime = 0f;
            }
            else
            {
                Debug.Log("�R�C���Ȃ���");
            }
        }
    }
}
