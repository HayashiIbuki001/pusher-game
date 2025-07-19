using UnityEngine;

public class PageController : MonoBehaviour
{
    public GameObject[] pages;
    private int currentIndex = 0;

    private void Start()
    {
        UpdatePage();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BackPage();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextPage();
        }
    }

    public void NextPage()
    {
        currentIndex = (currentIndex + 1) % pages.Length;
        UpdatePage();
    }

    public void BackPage()
    {
        currentIndex = (currentIndex + 1) % pages.Length;
        UpdatePage();
    }

    private void UpdatePage()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i == currentIndex);
        }
    }
}
