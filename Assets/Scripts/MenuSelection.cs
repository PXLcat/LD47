using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
    [SerializeField] private EventsManager eventsManger = default;
    [SerializeField] private Button[] optionsButtons = default;
    /// <summary>
    /// TMP component
    /// </summary>
    private TMP_Text[] optionsButtonsTexts = default;
    /// <summary>
    /// Default texts for the options
    /// </summary>
    private string[] optionsTexts = default;
    private char selectionChar = '>';

    private int currentSelectedOption;

    private void Awake()
    {
        //Init of TMP components and getting base texts so we can switch back
        for (int i = 0; i < optionsButtons.Length; i++)
        {
            optionsButtonsTexts[i] = optionsButtons[i].GetComponent<TMP_Text>();
            optionsTexts[i] = optionsButtonsTexts[i].text;

        }

        //Suscribe to buttons events (should I do this on the Inspector instead?
        optionsButtons[0].onClick.AddListener(StartGame);
        optionsButtons[1].onClick.AddListener(QuitGame);

    }

    //TODO Suscribing and Unsuscribing on Show/Hide methods


    private void StartGame()
    {
        
    }

    private void QuitGame()
    {

    }

    //TODO unsuscribe/remove listeners
}
