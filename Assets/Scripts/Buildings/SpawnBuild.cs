using UnityEngine;

public class SpawnBuild : MonoBehaviour
{
    public GameObject prefab;
    public void PlaceObject(Building building)
    {
        Instantiate(prefab, InputSync.MousePosition, Quaternion.Euler(0, 0, 0)).GetComponent<BuildingManager>().SetBuilding(building);
    }
}
