using TMPro;
using UnityEngine;

public class UiTime : MonoBehaviour
{
    [Header("Ui")]
    [SerializeField] private TextMeshProUGUI textTimer;
    [Header("Componets")]
    private UiEvents gameOver;

    private void Awake()
    {
        gameOver = GetComponent<UiEvents>();
    }
    private void Start()
    {
        TimerController.Timer += ChangeUiTime;
        TimerController.Timer += DeathUi;
    }
    private void OnDestroy()
    {
        TimerController.Timer -= ChangeUiTime;
        TimerController.Timer -= DeathUi;
    }
    private void ChangeUiTime(int minutes, float seconds)
    {
        textTimer.SetText($"{minutes}:{seconds:00}");
    }
    private void DeathUi(int minutes, float seconds)
    {
        if (minutes <= 0 && seconds <= 0)
        {
            gameOver.StartDeathUi();
        }
    }
}
