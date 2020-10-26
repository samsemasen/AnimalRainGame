using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour, IState
{
    [SerializeField] private PlayerMovement _player;
    [SerializeField] private GameObject _animalSpawner;
    [SerializeField] private GameObject _pauseButtonGMO;
    private Button _pauseButton;

    [SerializeField] private GameObject _healthBar;

    public void Enter()
    {
        Debug.Log("Entered Game state");

        _pauseButtonGMO.SetActive(true);
        _pauseButton = _pauseButtonGMO.GetComponentInChildren<Button>();
        _pauseButton.onClick.AddListener(HandlePauseButton);


        _player.enabled = true;
        _animalSpawner.SetActive(true);
        _healthBar.SetActive(true);
    }

    public void Exit()
    {
        _pauseButtonGMO.SetActive(false);
        _healthBar.SetActive(false);
        _animalSpawner.SetActive(false);
        _player.enabled = false;
    }


    private void HandlePauseButton()
    {
        GameManager.Instance.SetState(StateType.PauseGameState);
    }
}
