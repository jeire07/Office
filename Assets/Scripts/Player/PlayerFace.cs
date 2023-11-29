using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFace : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _PlayerRender;

    public CharacterControl _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterControl>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        //RotateFace(newAimDirection);
        // arc tangent �Լ��� ���� radian ���� degree�� ��ȯ
        float rotZ = Mathf.Atan2(newAimDirection.y, newAimDirection.x) * Mathf.Rad2Deg;

        // 90���� ������ ������ ���� ���̹Ƿ� �¿����
        _PlayerRender.flipX = Mathf.Abs(rotZ) > 90f;
    }

    private void RotateFace(Vector2 direction)
    {
        // arc tangent �Լ��� ���� radian ���� degree�� ��ȯ
        //float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 90���� ������ ������ ���� ���̹Ƿ� �¿����
        //_PlayerRender.flipX = Mathf.Abs(rotZ) > 90f;
    }


}
