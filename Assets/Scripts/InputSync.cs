using UnityEngine;

public class InputSync:MonoBehaviour
{
    private static InputStstem input;
    private void Awake()
    {
        input=new InputStstem();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

}
