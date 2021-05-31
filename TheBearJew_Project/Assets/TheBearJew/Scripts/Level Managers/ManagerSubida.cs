using System.Collections.Generic;
using UnityEngine;

public class ManagerSubida : MonoBehaviour
{
    public static ManagerSubida Instance { get; private set; }

    [Header("Enemies")]
    [SerializeField] private List<GameObject> _enemies = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void RemoveEnemiesFromList(GameObject enemy)
    {
        if (_enemies.Contains(enemy))
            _enemies.Remove(enemy);

        //if (_enemies.Count <= 0)
            //GameStatus.Instance.HasEnemyAlivePiso0F = false;
    }
}