using UnityEngine;
using TMPro;

public class CoinCountManager : MonoBehaviour
{
    [SerializeField, Tooltip("初期枚数")] private int startCoins = 100;
    [SerializeField] private TextMeshProUGUI currentCoinText;

    //　コインの枚数のUI更新
    private int _currentCoins;
    public int currentCoins
    {
        get => _currentCoins;
        set
        {
            _currentCoins = value;
            UpdateText();
        }
    }

    private void Start()
    {
        currentCoins = startCoins;
    }

    public bool UseCoin()
    {
        if (currentCoins > 0)
        {
            currentCoins--;
            return true;
        }
        return false;
    }

    private void UpdateText()
    {
        currentCoinText.text = $"枚数： {currentCoins} 枚";
    }
}
