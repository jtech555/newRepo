using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    [SerializeField] TextMeshPro timerText;
    [SerializeField] float remainingTime;
    [SerializeField] GameObject GameOverImage;
    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            GameOverImage.SetActive(true);
            timerText.color = Color.red;
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
