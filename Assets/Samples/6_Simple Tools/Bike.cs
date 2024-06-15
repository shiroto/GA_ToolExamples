using UnityEngine;

[ExecuteAlways]
public class Bike : MonoBehaviour
{
    [Multiline]
    public string frigginLongText;

    [Min(1f)]
    public float grip = 2;

    [Range(0f, 500f)]
    public float speed = 100;

    [ContextMenu("Reset Text")]
    public void ResetText()
    {
        frigginLongText = "This is the default text.";
    }

    private void Update()
    {
        transform.Rotate(transform.position, Time.deltaTime * speed);
    }
}