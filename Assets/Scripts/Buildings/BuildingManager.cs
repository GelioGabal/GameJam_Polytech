using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField] Building building;
    public void SetBuilding(Building building)
    {
        this.building = building;
        this.building.SetBuilding(gameObject);
    }
}
