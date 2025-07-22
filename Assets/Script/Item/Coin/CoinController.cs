using UnityEngine;

public class CoinController : MonoBehaviour
{
    private CoinPool coinPool;

    private void Start()
    {
        coinPool = Object.FindAnyObjectByType<CoinPool>();
    }

    private void Update()
    {
        if (transform.position.y <= -20f)
        {
            coinPool.ReturnCoin(gameObject);
        }
    }
}
