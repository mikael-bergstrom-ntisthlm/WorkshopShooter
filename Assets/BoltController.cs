using UnityEngine;

public class BoltController : MonoBehaviour
{
  [SerializeField]
  float speed = 5f;

  void Update()
  {
    transform.Translate(Vector2.up * speed * Time.deltaTime);

    if (transform.position.y > Camera.main.orthographicSize + 1)
    {
      Destroy(this.gameObject);
    }
  }
}
