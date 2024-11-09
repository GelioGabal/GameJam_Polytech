using UnityEngine;

public class InputSync:MonoBehaviour
{
    public static InputStstem input;
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
