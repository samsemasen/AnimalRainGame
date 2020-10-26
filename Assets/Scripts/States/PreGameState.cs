using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PreGameState : MonoBehaviour, IState
{
    [SerializeField] private GameObject _waitScreen;
    private InputController _inputController;


    public void Enter()
    {
        Debug.Log("Entered pregame game state");
        _inputController = new InputController(HandleInputResult);
        _waitScreen.SetActive(true);
    }

    private void HandleInputResult()
    {
        GameManager.Instance.SetState(StateType.GameState);
    }

    public void Exit()
    {
        _inputController = null;
        _waitScreen.SetActive(false);
    }

    private void Update()
    {
        if (GameManager.Instance.GetCurrentState() != this) return;

        _inputController?.GetInput();
    }

}
