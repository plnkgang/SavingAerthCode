using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsCounterObj : MonoBehaviour
{
    public PlayerStats numberEnemiesKilled;
    public Text killsNumber;

    void Update()
    {
        killsNumber.text = numberEnemiesKilled.killsCount.ToString();
    }
}
