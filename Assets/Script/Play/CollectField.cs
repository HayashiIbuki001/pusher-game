using UnityEngine;

public class CollectField : MonoBehaviour
{
    [SerializeField,Tooltip("CoinCountManager�X�N���v�g")] private CoinCountManager coinCountManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCountManager.currentCoins++;
            Destroy(other.gameObject);
        }
    }
}
