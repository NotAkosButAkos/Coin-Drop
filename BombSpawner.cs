using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{

    public float spawnRate;
    private float timer;
    public GameObject bomb;
    public float spawningOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBomb();
            timer = 0;
        }
    }

    void spawnBomb()
    {
        float leftOffset = transform.position.x - spawningOffset;
        float rightOffset = transform.position.x + spawningOffset;
        Instantiate(bomb, new Vector3(Random.Range(leftOffset, rightOffset), transform.position.y, -1), transform.rotation);
    }
}
