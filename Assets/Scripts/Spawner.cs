using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject item;
    public int count = 10;

    GameObject map;

    float x, y;
    float maxX, maxY;

	void Start ()
    {
        map = GameObject.FindGameObjectWithTag("Background");
        var mapSprite = map.GetComponent<SpriteRenderer>();
        var mapCollider = map.GetComponent<BoxCollider2D>();
        var itemSprite = item.GetComponent<SpriteRenderer>();

        float offset = Mathf.Min(mapCollider.size.x, mapCollider.size.y) + 
            Mathf.Max(itemSprite.bounds.size.x, itemSprite.bounds.size.y) / 2;

        maxX = mapSprite.sprite.bounds.size.x / 2 - offset;
        maxY = mapSprite.sprite.bounds.size.y / 2 - offset;
        Spawn(count);
    }

    void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            x = Random.Range(-maxX, maxX);
            y = Random.Range(-maxY, maxY);
            Instantiate(item, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
	
}
