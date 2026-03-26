using UnityEngine;
using UnityEngine.UI;

public class UiLifePlayer : MonoBehaviour
{
    [SerializeField] private Image lifeBar;
    private void Awake()
    {
        LifeController.LifeBar += Changelife;
    }
    public void Changelife(float hp, float maxHp)
    {
        lifeBar.fillAmount = hp / maxHp;
    }
    private void OnDestroy()
    {
        LifeController.LifeBar -= Changelife;
    }
}
