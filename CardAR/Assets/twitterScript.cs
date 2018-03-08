using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[DisallowMultipleComponent]
[RequireComponent(typeof(SpriteRenderer))]

public class twitterScript : MonoBehaviour
{


    [SerializeField] MeshRenderer target;
    SpriteRenderer srend;

    private void Awake()
    {
        srend = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        Application.OpenURL("https://twitter.com/tippytalk?lang=en");
    }

}