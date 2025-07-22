using UnityEngine;
using System.Collections.Generic;

public class CoinPool : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefub;
    [SerializeField,Tooltip("��������R�C���̐�")] private int poolsize = 300;

    private List<GameObject> pool;

    private void Awake()
    {
        pool = new List<GameObject>();
        for ( int i = 0; i < poolsize; i++ )
        {
            GameObject coin = Instantiate(coinPrefub);
            coin.SetActive(false);
            pool.Add(coin);
        }
    }

    public GameObject GetCoin()
    {
        foreach (var coin in pool)
        {
            if (!coin.activeInHierarchy)
            {
                coin.SetActive(true);
                return coin;
            }
        }

        // �v�[�����s��������
        GameObject newCoin = Instantiate(coinPrefub);
        pool.Add(newCoin);
        return newCoin;
    }

    public void ReturnCoin(GameObject coin)
    {
        coin.SetActive(false);
    }
}
