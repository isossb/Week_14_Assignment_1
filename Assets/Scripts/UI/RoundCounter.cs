using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    [SerializeField] RoundGUI roundGUI;

    private void Start ()
    {
        StartCoroutine(CountRounds());
    }

    private IEnumerator CountRounds ()
    {
        while (true)
        {
            roundGUI.Rounds += 1;

            yield return new WaitForSeconds(30);
        }
    }
}
