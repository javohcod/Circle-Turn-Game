using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bonus;
    public Transform spawnPos;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.2f);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Instantiate(bonus, pos, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
