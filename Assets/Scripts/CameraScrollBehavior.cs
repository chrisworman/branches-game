using UnityEngine;
using System.Collections;

public class CameraScrollBehavior : MonoBehaviour
{
    const float InitialSpeed = 2.0f;
    float Speed;

    // Use this for initialization
    void Start()
    {
        Speed = InitialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        transform.position += transform.up * Speed * Time.deltaTime;
    }
}
