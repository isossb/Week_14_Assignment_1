using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundGUI : MonoBehaviour
{
    [SerializeField] Text roundText;

    int rounds = 1;

    private void Awake ()
    {
        UpdateGUI();
    }

    public int Rounds
    {
        get
        {
            return rounds;
        }

        set
        {
            rounds = value;
        }
    }

    private void UpdateGUI ()
    {
        roundText.text = rounds.ToString();
    }
}
