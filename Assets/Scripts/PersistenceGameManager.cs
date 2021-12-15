using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenceGameManager : MonoBehaviour
{
    public static PersistenceGameManager Instance;
    public string PlayerName;
    public string BestPlayerName = "";
    public int BestScore = 0;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
