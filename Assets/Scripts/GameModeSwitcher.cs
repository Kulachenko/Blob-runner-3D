using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameModeSwitcher : MonoBehaviour
{
    [SerializeField] private MainMenuScreen _mainMenuScreen;
    [SerializeField] private GameInterface _gameInterface;
    [SerializeField] private Player _player;

    public event UnityAction GameStarted;

    private void Awake()
    {
        _gameInterface.Close();
        _mainMenuScreen.Open();
    }

    private void OnEnable()
    {
        _mainMenuScreen.ScreenTouched += OnScreenTouched;
    }

    private void OnDisable()
    {
        _mainMenuScreen.ScreenTouched -= OnScreenTouched;
    } 
    
    private void OnScreenTouched()
    {
        _mainMenuScreen.Close();
        _gameInterface.Open();

        GameStarted?.Invoke();
    }
}