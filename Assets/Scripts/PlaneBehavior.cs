using UnityEngine;

public class PlaneBehavior : MonoBehaviour
{
    private const float Angle = 0.5f;
    private Vector3 _mousePosition;

    private void OnMouseDrag()
    {
        Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float z = transform.rotation.eulerAngles.z;
        if (z < 340 && z > 338)
        {
            z = 341;
        }
        else if (z > 20 && z < 22)
        {
            z = 19;
        }
        if (_mousePosition.x > transform.position.x)
        {
            if (_mousePosition.y < currentPosition.y)
            {
                z += Angle;
            }
            else if (_mousePosition.y > currentPosition.y)
            {
                z -= Angle;
            }
        }
        else if (_mousePosition.x < transform.position.x)
        {
            if (_mousePosition.y < currentPosition.y)
            {
                z -= Angle;
            }
            else if (_mousePosition.y > currentPosition.y)
            {
                z += Angle;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, z);
        _mousePosition = currentPosition;
    }

    private void OnMouseDown()
    {
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}


