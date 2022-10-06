using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerTicTacToe : MonoBehaviour
{
    //Array aus den Elements
    [SerializeField] private BoxTicTacToe[] arrayTTT;
    [SerializeField] private Image imgP1, imgP2;

    public bool player1;
    
    public Sprite spWhite, spX, spO;

    // Start is called before the first frame update
    void Start()
    {
        player1 = false;
        ShowPlayer1Active(player1);
    }

    public void ShowPlayer1Active(bool isPlayer1)
    {
        if (isPlayer1)
        {
            imgP1.color = Color.green;
            imgP2.color = Color.white;
        }
        else
        {
            imgP2.color = Color.green;
            imgP1.color = Color.white;
        }
    }

    public void ResetBoard()
    {
        for(int i = 0; i < arrayTTT.Length; i++)
        {
            arrayTTT[i].SetImageBasedOnState(StateTTT.white);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
