using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput _playerInput;
    private InputAction _mousePosition;
    private InputAction _mouseLeftButtonClick;
    private InputAction _keyboardPressed;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _mousePosition = _playerInput.actions["MousePosition"];
        _mouseLeftButtonClick = _playerInput.actions["MouseLeftButtonClick"];
        _keyboardPressed = _playerInput.actions["KeyboardPressed"];
    }

    private void OnEnable()
    {
        // _mousePosition.performed += ;
    }

    private void OnDisable()
    {
        
    }
}
