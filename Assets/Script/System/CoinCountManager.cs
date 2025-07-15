
using UnityEngine;
using TMPro;

public class CoinCountManager : MonoBehaviour
{
    [SerializeField,Tooltip("‰Šú–‡”")] private int startCoins = 100;
    public int currentCoins;

    public TextMeshProUGUI currentCoinText;

    


    private void Start()
    {
        currentCoins = startCoins;
        TextUpdate();
    }

    public bool UseCoin()
    {
        if (currentCoins > 0)
        {
            currentCoins--;
            TextUpdate();

            return true;
        }
        else
        {
            return false;
        }
    }

    void TextUpdate()
    {
        currentCoinText.text = $"–‡”F {currentCoins} –‡";
    }
}
