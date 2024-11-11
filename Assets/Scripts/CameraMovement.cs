using UnityEngine;

public class CameraMovement:MonoBehaviour
{
    [SerializeField] float speed, scrollSpeed;
    [SerializeField] float minZoom = 2, maxZoom = 15;
    Camera cam;
    void Start() => cam = GetComponent<Camera>();
    void FixedUpdate()
    {
        transform.Translate(InputSync.Input.Camera.Movement.ReadValue<Vector2>() * speed * Time.fixedDeltaTime);
        cam.orthographicSize -= InputSync.Input.Camera.Zoom.ReadValue<Vector2>().normalized.y * scrollSpeed;
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minZoom, maxZoom);
    }
}
