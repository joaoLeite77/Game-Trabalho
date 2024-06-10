using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum GameStatus
{
    Start,
    Play,
    GameOver
}
public class GameController : MonoBehaviour
{
    private bool isGameRunning;
    //propiedades do chão
    [Header("Configuração do chão")]
    public float        _chaoDestruido;
    public float        _chaoTamanho;
    public float        _chaoVelocidade;
    public GameObject   _chaoPrefab;

    public Player player;
    public GameStatus status = GameStatus.Start;
    public TextMeshProUGUI scoreLabel;
    public GameConfiguration config;

    private void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
        isGameRunning = false;
    }

    private void Update()
    {
    }
    void StartGame()
    {
        status = GameStatus.Play;
        isGameRunning =true;
    }

    public void GameOver()
    {
        isGameRunning = false;
    }
    void Play()
    {
        
    }

}

public class GameConfiguration
{
}