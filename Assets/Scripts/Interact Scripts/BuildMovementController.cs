using UnityEngine;
using UnityEngine.InputSystem;

public class BuildMovementController:MonoBehaviour
{
    [SerializeField] LayerMask ground;
    Camera cam;

    private void Awake()
    {
       
        cam=Camera.main;
    }

    private void BuildMovenent(Vector2 position)
    {
        position=cam.ScreenToWorldPoint(position);
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
        
        PlaceObject();
    }



}
