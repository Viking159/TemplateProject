using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class InventoryItemSO : ItemSOBase
{
    [SerializeField] protected int _quantity;
    [SerializeField] protected string _rareness;

    public int Quantity => _quantity;
    public string Rareness => _rareness;

}
