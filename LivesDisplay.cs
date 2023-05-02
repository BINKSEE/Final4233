using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public Text LivesText;

    private void Start()
    {
        // Get the selected number of lives from the PlayerPrefs
        int lives = PlayerPrefs.GetInt("SelectedLives", 3);

        // Update the lives text to display the selected number of lives
        LivesText.text = lives.ToString();
    }
}


