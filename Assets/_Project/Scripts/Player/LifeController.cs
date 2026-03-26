using System;
using UnityEngine;
using UnityEngine.Events;
public class LifeController : MonoBehaviour
{
    [SerializeField] private float hp = 200;
    [SerializeField] private float maxHp = 200;

    public static event Action<float, float> LifeBar;
    [SerializeField] private UiEvents uiMananager;
    private void Start()
    {
        hp = maxHp;
        LifeBar?.Invoke(hp, maxHp);
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            DiePlayer();
        }
        LifeBar?.Invoke(hp,maxHp);
    }
    public void DiePlayer()
    {
        uiMananager.StartDeathUi();
        Destroy(gameObject);
    }
}
