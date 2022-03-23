using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _target;
    private GameObject _player;
    private float _smoothing;
    private Vector2 _maxPosition, _minPosition;
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        _target = _player.transform;
        _maxPosition = new Vector2(21f, 20f);
        _minPosition = new Vector2(-10f, -21f);
        _smoothing = 5;
    }
    private void Update()
    {
        _player = GameObject.FindWithTag("Player");
        _target = _player.transform;
    }
    void LateUpdate()
    {
        if (transform.position != _target.position)
        {
            Vector3 targetPosition = new Vector3(_target.position.x, _target.position.y + -0.346f, -10);
            targetPosition.x = Mathf.Clamp(targetPosition.x, _minPosition.x, _maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, _minPosition.y, _maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, _smoothing);

            //-0.346
        }
    }
}
