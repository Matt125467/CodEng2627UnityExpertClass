using UnityEngine;

[CreateAssetMenu(fileName = "BuildingType", menuName = "Scriptable Objects/BuildingType")]
public class BuildingTypeSO : ScriptableObject
{
    public string BuildingName;
    public Transform Prefab;
}