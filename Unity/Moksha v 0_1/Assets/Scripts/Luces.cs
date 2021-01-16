﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luces : MonoBehaviour
{
    [SerializeField] GameObject prefabLuz;
    [SerializeField] Transform InitPos;
    private Vector3 RandomPos;
    private float randomNumber1;
    private float randomNumber2;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        InstanciarLuz();
        contador = 0;
    }

    void InstanciarLuz()
    {
        randomNumber1 = Random.Range(-13f, 13f);
        randomNumber2 = Random.Range(-13f, 13f);
        RandomPos = new Vector3(randomNumber1, 0, randomNumber2);
        InitPos.transform.position = RandomPos;
        Instantiate(prefabLuz, InitPos);
    }

    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "Robot Kyle")
        {
            Destroy(this.prefabLuz);
            if (contador < 4)
            {
                InstanciarLuz();
                contador++;

            }

        }
        Debug.Log(contador);

    }
}
