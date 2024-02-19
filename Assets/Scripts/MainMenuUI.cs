using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "level1";
    public void NewGameButton()
{
    SceneManager.LoadScene(newGameLevel);
}
}
