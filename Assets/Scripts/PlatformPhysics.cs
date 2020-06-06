using UnityEngine;

public class PlatformPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 0.1f, 0);
    }
}