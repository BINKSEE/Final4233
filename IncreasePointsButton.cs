using UnityEngine;
using UnityEngine.UI;

public class IncreasePointsButton : MonoBehaviour
{
    public Text pointsText;
    private static int points = 0;

    private void Start()
    {
        pointsText.text = points.ToString();
    }

    public void OnIncreasePointsButtonClicked()
    {
        points++;
        pointsText.text = points.ToString();
    }

    public static int GetPoints()
    {
        return points;
    }

    public static void SetPoints(int newPoints)
    {
        points = newPoints;
    }
}



