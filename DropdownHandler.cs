using UnityEngine;
using UnityEngine.UI;

public class DropdownHandler : MonoBehaviour
{
    public Dropdown dropdown;
    public static int SelectedLives;

    private void Start()
    {
        // Load the previously saved value of lives
        int savedLives = PlayerPrefs.GetInt("SelectedLives", 3);

        // Set the default value of the dropdown to the saved value of lives
        dropdown.value = savedLives - 1;
    }

    public void OnDropdownValueChanged()
    {
        // Save the selected value of lives to PlayerPrefs
        int SelectedLives = dropdown.value + 1;
        PlayerPrefs.SetInt("SelectedLives", SelectedLives);
        PlayerPrefs.Save();
        Debug.Log("Selected lives saved in PlayerPrefs: " + SelectedLives);
    }
}

