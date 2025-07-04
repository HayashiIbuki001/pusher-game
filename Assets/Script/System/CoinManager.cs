using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coinPrefub;
    private int rows = 5;
    private int columns = 5;
    [SerializeField, Tooltip("ƒRƒCƒ“‚ÌŠÔŠu")] float space = 3.2f;
    [SerializeField] private Vector3 startPos = new Vector3(-8, 10, -16);

    private void Start()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Vector3 pos = startPos + new Vector3(i * space, k * 0.8f, j * space);
                    Instantiate(coinPrefub, pos, Quaternion.identity);
                }
            }
        }
    }
}
