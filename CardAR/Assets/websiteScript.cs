using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[DisallowMultipleComponent]
[RequireComponent(typeof(SpriteRenderer))]

public class websiteScript : MonoBehaviour {


    [SerializeField] MeshRenderer target;
    SpriteRenderer srend;

    private void Awake()
    {
        srend = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Application.OpenURL("http://tippy-talk.com");
    }

}