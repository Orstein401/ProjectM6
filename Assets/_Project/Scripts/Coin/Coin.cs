using System;
using UnityEngine;
using UnityEngine.Events;
public class Coin : MonoBehaviour
{
    [Header("MovementCoin")]
    [SerializeField] private float speed;
    [SerializeField] private float amplitude;
    [SerializeField] private float speedRotation;

    [Header("Value and Count")]
    [SerializeField] private int valueCoin;
    public static event Action<int> OnCoinTake;

    private void Update()
    {
        MoveCoin();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out var player))
        {
            AddCoin();
            Destroy(gameObject);
        }
    }
    private void MoveCoin()
    {
        float angle = Time.time * speed;
        float move = transform.position.y - Mathf.Sin(angle) * amplitude * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, move, transform.position.z);
        transform.Rotate(Vector3.up*speedRotation*Time.deltaTime);
    }
    private void AddCoin()
    {
        OnCoinTake?.Invoke(valueCoin);
    }
}
