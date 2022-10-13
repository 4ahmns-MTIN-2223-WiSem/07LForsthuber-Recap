using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum StateTTT
{
    white,
    playerX,
    playerO
}

public class BoxTicTacToe : MonoBehaviour
{
    public StateTTT myState;
    private Image myImage;
    [SerializeField] private ManagerTicTacToe myManager;


    // Start is called before the first frame update
    void Start()
    {
        myState = StateTTT.white;

        myImage = gameObject.GetComponent<Image>();
        myManager = FindObjectOfType<ManagerTicTacToe>();

        SetImageBasedOnState(myState);

    }

    public void PressMe()
    {
        var manager = GameObject.Find("Manager").GetComponent<ManagerTicTacToe>();
        Debug.Log(gameObject.name);
        if (myManager.player1)
        {
            myState = StateTTT.playerX;
        }
        else
        {
            myState = StateTTT.playerO;
        }
        SetImageBasedOnState(myState);

        myManager.player1 = !myManager.player1;
        myManager.ShowPlayer1Active(myManager.player1);

        manager.WinnerCheck(myState, 0, 1, 2);
        manager.WinnerCheck(myState, 3, 4, 5);
        manager.WinnerCheck(myState, 6, 7, 8);
        manager.WinnerCheck(myState, 0, 3, 6);
        manager.WinnerCheck(myState, 1, 4, 7);
        manager.WinnerCheck(myState, 2, 5, 8);
        manager.WinnerCheck(myState, 0, 4, 8);
        manager.WinnerCheck(myState, 2, 4, 6);

        
    }

    public void SetImageBasedOnState(StateTTT state)
    {
        switch (state)
        {
            case StateTTT.white:
                myImage.sprite = myManager.spWhite;
                break;
            case StateTTT.playerO:
                myImage.sprite = myManager.spO;
                break;
            case StateTTT.playerX:
                myImage.sprite = myManager.spX;
                break;
        }
    }
}
