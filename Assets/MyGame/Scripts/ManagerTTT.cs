using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTTT : MonoBehaviour
{
    public TicTacToe[] game;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < game.Length; i++)
        {
            game[i].GetComponent<TicTacToe>().myState = TTTState.O;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
