using UnityEngine;
using System;
using UnityEngine.Rendering;

public class Notas
{
    public string notas;
}

public class Apuntes : MonoBehaviour
{
    //Accesibilidad (nivel de proteccion), tipo de variable, nombre, (Opcional) valor
    [SerializeField]
    private int numEntero = 5;
    private float numDecimalesFalsos = 5.5f;
    private double numDecimalesPartidos = 5.5;
    private string cadenaCharacters = "cinco";
    private char character = 'c';
    private bool boleano = true;//false
    private Vector3 vector3D = new Vector3(2, 6, 9); //x,y,z
    private Vector2 vector2D = new Vector2(5, 4); //x,y
    private Transform trans;
    public MeshRenderer mesh;
    private CapsuleCollider colliderObjeto;
    private Material material;
    private Apuntes nustrosScripts;
    private Animator animator;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    //Se ejecuta lo primero de todo
    void Awake()
    {
        Debug.Log("Awake");
    }

    //Cada vez que se activa el objeto con este script, o cada vez que se active el script
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    //Se ejecuta cada vez que se desactiva el objeto o el script
    private void OnDisable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Se ejecuta todo el tiempo cada x segundos definidos en projectSettings
    private void FixedUpdate()
    {
        
    }

    //Se ejecuta al final de todo de cada frame
    private void LateUpdate()
    {
        
    }

    //Se ejecutará el primer frame que detecta la collision
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    //Se ejecutará el primer frame que deje de detectar la colision
    private void OnCollisionExit(Collision collision)
    {
        
    }

    //Se ejecuta mientrás se está produciendo la colision
    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
