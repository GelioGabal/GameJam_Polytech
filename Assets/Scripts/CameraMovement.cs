using UnityEngine;

public class CameraMovement:MonoBehaviour
{

    Vector2 _Movement;
   [SerializeField] private float _Speed;
    
    private void FixedUpdate()
    {
        OnMovement(InputSync.input.Standart.Movement.ReadValue<Vector2>());
    }

    private void OnMovement(Vector2 movement)
    {
        transform.position += new Vector3(movement.x, movement.y) * _Speed * Time.deltaTime;
    }

}
