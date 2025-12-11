using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("HelloWorldAwake");
    }

    public void Start()
    {
        Debug.Log("HelloWorldStart");
        Debug.Log("Hello World");
    }
}