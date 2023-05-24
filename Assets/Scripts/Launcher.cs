using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    private Button startButton;

    void Awake()
    {
        startButton = transform.Find("StartBtn").GetComponent<Button>();
        startButton.onClick.AddListener(OnStartClick);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Gaze");
    }
}