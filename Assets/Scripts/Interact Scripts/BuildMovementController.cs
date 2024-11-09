using Unity.VisualScripting;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuildMovementController:MonoBehaviour
{
    private LayerMask ground;


    private void Awake()
    {
       
    }



    private void BuildMovenent(Vector2 position)
    {
        transform.position = position;

    }

    private void PlaceObject()
    {
        BuildMovenent(InputSync.input.Standart.MousePos.ReadValue<Vector2>());
        if (InputSync.input.Standart.leftCkick.IsPressed()) 
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            Destroy(gameObject.GetComponent<BuildMovementController>());
        }
    }
    

    private void FixedUpdate()
    {
        Debug.Log(InputSync.input.Standart.MousePos.ReadValue<Vector2>());
        PlaceObject();
    }



}
