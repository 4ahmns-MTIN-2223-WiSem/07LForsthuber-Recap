using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerTicTacToe : MonoBehaviour
{
    //Array aus den Elements
    [SerializeField] private BoxTicTacToe[] arrayTTT;
    [SerializeField] private Image imgP1, imgP2;

    public bool player1;
    public bool winStatus;
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
            imgP1.color = Color.white;
            imgP2.color = Color.grey;
        }
        else
        {
            imgP2.color = Color.white;
            imgP1.color = Color.grey;
        }
    }

    public void WinnerCheck(StateTTT Player, int one, int two, int three)
    {


        for (int i = 0; i < 3; i++)
        {

            if (arrayTTT[one].GetComponent<BoxTicTacToe>().myState == Player && arrayTTT[two].GetComponent<BoxTicTacToe>().myState == Player && arrayTTT[three].GetComponent<BoxTicTacToe>().myState == Player)
            {
                winStatus = true;
                arrayTTT[one].GetComponent<Image>().color = Color.green;
                arrayTTT[two].GetComponent<Image>().color = Color.green;
                arrayTTT[three].GetComponent<Image>().color = Color.green;


            }

        }

        if (winStatus)
        {
            Debug.Log("Player " + Player + " won");
        }

    }

    public void ResetBoard()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
