using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Button redButton;
    public Button greenButton;
    public Button blueButton;
    public Button switchButton;

    private bool redButtonClicked;
    private bool greenButtonClicked;
    private bool blueButtonClicked;

    // Start is called before the first frame update
    void Start()
    {
        redButton.GetComponent<Image>().color = Color.red;
        greenButton.GetComponent<Image>().color = Color.green;
        blueButton.GetComponent<Image>().color = Color.blue;

        switchButton.interactable = false;
    }

    public void ChangeRed()
    {
        redButton.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void ChangeGreen()
    {
        greenButton.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void ChangeBlue()
    {
        blueButton.GetComponent<Image>().color = Random.ColorHSV();
    }

    public void ClickStatus(int buttonNumber)
    {
        if (buttonNumber == 0)
            redButtonClicked = true;

        if (buttonNumber == 1)
            greenButtonClicked = true;

        if (buttonNumber == 2)
            blueButtonClicked = true;

        CheckBtnPressed();

    }

    void CheckBtnPressed()
    {
        if ((!switchButton.interactable) && redButtonClicked && greenButtonClicked && blueButtonClicked)
        {
            switchButton.interactable = true;
        }
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }
}
