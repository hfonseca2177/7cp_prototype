using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    
    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 newCameraPosition = new Vector3(target.position.x,target.position.y, transform.position.z);
            newCameraPosition.x = Mathf.Clamp(newCameraPosition.x, minPosition.x, maxPosition.x);
            newCameraPosition.y = Mathf.Clamp(newCameraPosition.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, newCameraPosition, smoothing);
        }
    }
}
