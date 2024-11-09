using UnityEngine;

public class SpawnBuild : MonoBehaviour
{
    public GameObject buld;
    public void PlaceObject()
    {

            Instantiate(buld, Vector2.zero, Quaternion.Euler(0, 0, 0));
        buld.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}
