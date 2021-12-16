using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
/*
public enum GameState {PlayerDiceRoll, PlayerSelectTile, PlayerSelectAction, EnemyTurn, GameEnd};
public class TurnController : Networkbehaviour {
    
    public 
    public GameState curState; //tracks current state of the game

    if(countdownTime == 0) {
        curState = GameState.EnemyTurn;
    }
        
    if(GlobalData.instance.playerID == 0)
    {
            curState = GameState.PlayerDiceRoll;
    }
    else
    {
        curState = GameState.EnemyTurn;
    }
    void Update() {
        switch (curState)
        {
            case GameState.PlayerDiceRoll:
            Dice int_Dice_Roll GetComponent<Dice>;
                if (int_Dice_Roll <7)
                {
                Debug.Log($"You Rolled a {int_Dice_Roll}!")
                }
                break;
        }
            case GameState.PlayerSelectAction:
            Tile_Selector Tile GetComponent<Tile_Selector>;
                //idk if this part is relavent, something to do with stat checking and taking tiles
                //state cant change to enemy turn after this unless timer up or end turn button pressed
                /*if (EndTurn){
                    Debug.Log("Turn Over")
                }
                break; 
                
    } 
}   
*//*
public class EndTurn : Networkbehaviour
{
   public void OnEndTurnButton()
    {
        if (GameState != curState.PlayerSelectTile || curState.PlayerSelectAction)
          return;  
        
        StartCoroutine(EnemyTurn());
    }

}
//this has a crazy amount of errors in it, may have to change all of it tbh :(
   this will be put into the endturn object, which is on then put into 
   the endturn button to get the functiob */