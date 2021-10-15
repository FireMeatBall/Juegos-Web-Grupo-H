using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour
{
    private InputPlayerMap map;
    private InputAction click;
    private InputAction position;

    private bool isDragging;
    private Vector2 mousePos;

    public Action<Vector2> OnPress, OnDrag, OnRelease;

    private void Awake()
    {
        map = new InputPlayerMap();
    }

    private void OnEnable()
    {
        click = map.Player.Click;
        click.started += Press;
        click.canceled += Release;
        click.Enable();

        position = map.Player.Position;
        position.performed += Move;
        position.Enable();
    }

    private void Move(InputAction.CallbackContext ctx)
    {
        mousePos = ctx.ReadValue<Vector2>();
        if (isDragging)
            OnDrag?.Invoke(mousePos);
    }

    public void Press(InputAction.CallbackContext ctx)
    {       
        isDragging = true;
        OnPress?.Invoke(mousePos);
    }

    private void Release(InputAction.CallbackContext ctx)
    {        
        isDragging = false;
        OnRelease?.Invoke(mousePos);
    }

    private void OnDisable()
    {
        click.Disable();
        position.Disable();
    }

}
