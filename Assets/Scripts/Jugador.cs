﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    private float Speed;

    //public int puntos;
    //public Text TxTpuntos;

    public Jugador()
    {

    }

    ////public void sethp(int daño)
    ////{
    ////    this. -= daño;
    ////}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

       // TxTpuntos.text = "Puntos:" + puntos;
    }

    public Jugador(int Speed, int vid, float Spee, int daño)
    {
        this.Speed = Speed;
    }

    public void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * Speed;
        }
    }



}
