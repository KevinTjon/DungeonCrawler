using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Objects/Dungeon/Room Node Type List")]

public class RoomNodeTypeListSO : ScriptableObject
{
    public List<RoomNodeTypeSO> list;

#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEnumerableValues(this, nameof(list),list);
    }
#endif
 
}
