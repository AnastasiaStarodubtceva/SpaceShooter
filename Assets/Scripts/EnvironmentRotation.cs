using UnityEngine;

public class EnvironmentRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeedX;
    [SerializeField] private float _rotationSpeedY;
    [SerializeField] private float _rotationSpeedZ;

    private void FixedUpdate()
    {
        transform.Rotate(_rotationSpeedX * Time.fixedDeltaTime, _rotationSpeedY * Time.fixedDeltaTime, _rotationSpeedZ * Time.fixedDeltaTime);
    }
}
