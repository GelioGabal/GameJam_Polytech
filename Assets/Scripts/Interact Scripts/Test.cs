using UnityEngine;

public class Test:MonoBehaviour
{
    private void Update()
    {
        Debug.Log(InputSync.input.Standart.MousePos.ReadValue<Vector2>());
    }
}
