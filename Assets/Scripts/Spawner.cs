using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _delay;

    private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _delay, _repeatRate);
    }

    private void Spawn()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
    }
}
