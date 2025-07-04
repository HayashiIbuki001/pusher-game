using UnityEngine;

public class CoinCountManager : MonoBehaviour
{
    [SerializeField,Tooltip("‰Šú–‡”")] private int startCoins = 100;
    public int currentCoins;

    private void Awake()
    {
        currentCoins = startCoins;
    }

    public bool UseCoin()
    {
        if (currentCoins > 0)
        {
            currentCoins--;
            Debug.Log("–‡”F" + currentCoins + "–‡");

            return true;
        }
        else
        {
            return false;
        }
    }
}
