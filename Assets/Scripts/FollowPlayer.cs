using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;

    // Update is called once per frame
    void LateUpdate()
    {
        float x = _player.position.x + 1f;
        float y = _player.position.y + 1.15f;

        transform.position = new Vector3(x, y, -10f);
    }
}
