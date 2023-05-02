using UnityEngine;
using UnityEngine.UI;

public class IncreaseLivesButton : MonoBehaviour
{
    public Text LivesText;
    private static int Lives = 0;

    private void Start()
    {
        LivesText.text = Lives.ToString();
    }

    public void OnIncreaseLivesButtonClicked()
    {
        Lives++;
        LivesText.text = Lives.ToString();
    }

    public static int GetLives()
    {
        return Lives;
    }

    public static void SetLives(int newLives)
    {
        Lives = newLives;
    }
}
