using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSOBase : ScriptableObject
{
    [SerializeField] protected string _name;
    [SerializeField] protected Sprite _icon;

    public string Name => _name;
    public Sprite Icon => _icon;
}
