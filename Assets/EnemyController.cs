using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    Vector2 newPos = new()
    {
      x = Random.Range(
        -Camera.main.orthographicSize * Camera.main.aspect + 1,
        Camera.main.orthographicSize * Camera.main.aspect - 1
      ),
      y = Camera.main.orthographicSize + 1
    };
    transform.position = newPos;
  }

  // Update is called once per frame
  void Update()
  {

  }
}
