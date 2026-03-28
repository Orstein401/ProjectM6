using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UiCoin : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCoin;
    [SerializeField] private int maxCoin;
    private int currentCoin;
    private UiEvents uiMangaer;

    private void Awake()
    {
        uiMangaer=GetComponent<UiEvents>();
    }
    private void Start()
    {
        textCoin.SetText($"{currentCoin}/{maxCoin}");
        Coin.OnCoinTake += AddCoinToCounter;
    }
    public void AddCoinToCounter(int numCoin)
    {
        currentCoin += numCoin;
        textCoin.SetText($"{currentCoin}/{maxCoin}");
        CheckCoin();
    }
    private void CheckCoin()
    {
        if (currentCoin >= maxCoin)
        {
            uiMangaer.StartWinUi();
        }
    }
    private void OnDestroy()
    {
        Coin.OnCoinTake -= AddCoinToCounter;
    }
}
