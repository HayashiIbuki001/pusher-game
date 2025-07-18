using UnityEngine;
using TMPro;

public class CoinCountManager : MonoBehaviour
{
    [SerializeField, Tooltip("��������")] private int startCoins = 100;
    [SerializeField] private TextMeshProUGUI currentCoinText;

    //�@�R�C���̖�����UI�X�V
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
        currentCoinText.text = $"�����F {currentCoins} ��";
    }
}
