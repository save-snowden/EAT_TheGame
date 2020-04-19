﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpwner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] fruits;

    private BoxCollider2D col;

    float x1, x2;


    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;

    }

    void Start()
    {
        StartCoroutine(SpwanFruit(0.3f));
    }
    void Update()
    {
        
    }
    IEnumerator SpwanFruit(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate(fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);

        StartCoroutine(SpwanFruit(Random.Range(0.5f, 1f)));

    }
}
