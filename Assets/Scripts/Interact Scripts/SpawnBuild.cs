using UnityEngine;

public class SpawnBuild : MonoBehaviour
{
    public GameObject buld;
    public void PlaceObject()
    {
        Instantiate(buld, InputSync.MousePosition, Quaternion.Euler(0, 0, 0));
    }
}
