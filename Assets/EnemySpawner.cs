using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
  [SerializeField]
  GameObject enemyPrefab;

  [SerializeField]
  float timeBetweenEnemies = 2;
  float timeSinceLastEnemy = 0;

  void Update()
  {
    timeSinceLastEnemy += Time.deltaTime;
    if (timeSinceLastEnemy > timeBetweenEnemies)
    {
      Instantiate(enemyPrefab);
      timeSinceLastEnemy = 0;
    }
  }
}
