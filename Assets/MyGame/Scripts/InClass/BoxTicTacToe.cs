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
    private StateTTT myState;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
