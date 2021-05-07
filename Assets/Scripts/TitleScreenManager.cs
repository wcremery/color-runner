using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
    private GameObject _titleScreen;
    private Button _startButton;
    private Button _quitButton;

    void Start()
    {
        GetRefs();
        SetupButtons();
    }

    private void SetupButtons()
    {
        SetupStartButton();
        SetupQuitButton();
    }

    private void SetupQuitButton()
    {
        _quitButton.onClick.AddListener(() => Application.Quit(0));
    }

    private void SetupStartButton()
    {
        _startButton.onClick.AddListener(() => SceneManager.LoadScene(1));
    }

    private void GetRefs()
    {
        _titleScreen = transform.Find("TitleScreen").gameObject;
        _startButton = _titleScreen.transform.Find("Buttons/Start").GetComponent<Button>();
        _quitButton = _titleScreen.transform.Find("Buttons/Quit").GetComponent<Button>();
    }
}
