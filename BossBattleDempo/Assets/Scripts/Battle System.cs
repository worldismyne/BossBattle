using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class Battlesystem : MonoBehaviour

{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    Unit Nagen;
    Unit Boss;

    public Text dialogueText;

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
      
        Nagen = playerPrefab.GetComponent<Unit>();

        Boss = enemyPrefab.GetComponent<Unit>();

        dialogueText.text = "Oh no" + Boss.unitName + "has declared war.";
    }
}
