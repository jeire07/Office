using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputEventCheck : CharacterControl
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    // W, A, S, D move event
    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    // Arrow key move event
    public void OnMove2(InputValue value)
    {
        // Debug.Log("OnMove2" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    // mouse cursor event
    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }

    // will be used for mouse click move event
    public void OnLeftClick(InputValue value)
    {
        Debug.Log("OnLeftClick" + value.ToString());

        // not implemented code
    }
}
