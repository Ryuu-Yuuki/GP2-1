using UnityEngine;

public class Peebot : MonoBehaviour
{
    [SerializeField] public float revolveSpeed = 80f;
    Vector2 pivotPoint = Vector2.zero;
    Vector3 axis = Vector3.forward;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) {
            revolveSpeed *= -1;
        }
        transform.RotateAround(pivotPoint,axis,revolveSpeed*Time.deltaTime);
    }
}
