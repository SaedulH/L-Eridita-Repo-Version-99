using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
     
/*
public class CountdownController : Networkbehaviour
{
    [SyncVar]
    public int countdownTime == 60;

    [SyncVar]
    public Text countdownDisplay;

    private void Start() {
        StartCoroutine(CountdownTurn());
    }

    IEnumerator CountdownTurn() {
        while(countdownTime > 0 ) {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "Turn Over";
        TurnController.EnemyTurn();

        yield return new WaitForSeconds(1f);
    }
}
So the timer function doesnt work until there's a working end turn function 
but i cant get that to work either...(also not really sure how to use coroutines)
This will be place within the countdown timer UI (somehow) */