using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player")]
public sealed class PlayerSO : ItemSOBase
{
    [SerializeField] private int _level;
    [SerializeField] private GameObject _model;

    public int Level => _level;
    public GameObject Model => _model;
}
