using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{

    /// <summary>
    /// Transform.RotateAround��p�����~�^��
    /// </summary>

    // ���S�_
    [SerializeField] private Vector3 _center = Vector3.zero;

    // ��]��
    [SerializeField] private Vector3 _axis = Vector3.up;

    // �~�^������
    [SerializeField] private float _period = 2;

    private void Update()
    {
        // ���S�_center�̎�����A��axis�ŁAperiod�����ŉ~�^��
        transform.RotateAround(
        _center,
        _axis,
        360 / _period * Time.deltaTime
        );
    }
}
