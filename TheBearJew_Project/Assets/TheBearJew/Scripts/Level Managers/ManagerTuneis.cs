using System.Collections.Generic;
using UnityEngine;

public class ManagerTuneis : MonoBehaviour
{
    public static ManagerTuneis Instance { get; private set; }

    public bool IsDynamiteInPlace { get; set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void LevelEndUpdate()
    {
        
    }

}