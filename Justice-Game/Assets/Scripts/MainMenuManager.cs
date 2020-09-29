using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    private int timeElapsed;
    public Text titleText;
    public Text titleTextShadow;
    public Text startButtonText;
    public GameObject mainPanel;
    public GameObject infoPanel;
    void Awake()
    {
        titleTextShadow.text = titleText.text;
        HideInfoScreen();
    }
    void Update()
    {
        timeElapsed++;
        if (timeElapsed < 100)
            startButtonText.color = new Color32(237, 191, 18, 255);
        else
            startButtonText.color = Color.black;
        if (timeElapsed > 200)
            timeElapsed = 0;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ShowInfoScreen()
    {
        infoPanel.gameObject.SetActive(true);
    }

    public void HideInfoScreen()
    {
        infoPanel.gameObject.SetActive(false);
    }
}
