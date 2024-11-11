using UnityEngine;

public class InputSync:MonoBehaviour
{
    public static InputStstem Input;
    static Camera cam;
    private void Awake()
    {
        cam = Camera.main;
        Input = new InputStstem();
    }

    private void OnEnable()
    {
        Input.Enable();
    }

    private void OnDisable()
    {
        Input.Disable();
    }
    public static Vector2 MousePosition { get => cam.ScreenToWorldPoint(Input.Player.MousePos.ReadValue<Vector2>()); }
}
