using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealsCounter : MonoBehaviour
{
    public PlayerStats playerHealsLeft;
    public Text healsCounterText;

    void Update()
    {
        healsCounterText.text = playerHealsLeft.healsCount.ToString();
    }
}
