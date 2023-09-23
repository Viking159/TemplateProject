using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Map", menuName = "Map")]
public sealed class MapSO : ItemSOBase
{
    [SerializeField] private string _discription;
    [SerializeField] private int _id;
    [SerializeField] private Sprite _mapImage;

    public string Discription => _discription;
    public int ID => _id;
    public Sprite MapImage => _mapImage;
}
