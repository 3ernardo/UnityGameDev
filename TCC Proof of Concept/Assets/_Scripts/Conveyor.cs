﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public GameObject belt;
    public Transform endpoint;
    public float speed = 1f;

    private void OnTriggerStay(Collider other) {
        other.transform.position = Vector3.MoveTowards(other.transform.position, endpoint.position, speed * Time.deltaTime);
    }
}