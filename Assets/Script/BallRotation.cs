using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CentralCircle;
    bool direction = false;

    private void FixedUpdate()
    {
        if (direction == false)
            CentralCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
        else
            CentralCircle.transform.Rotate(0, 0, -150 * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        direction = !direction;
    }
}
