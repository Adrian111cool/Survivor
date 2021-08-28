﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody; // Es la variable que luego de enlazarse con el componente
                                  // Maneja las físicas de nuestro player.

    [Header("Movement Properties")]
    public int direction; // Es la dirección a la que se está moviendo nuestro player
    public float moveSpeed; // Es la velocidad a la que se mueve nuestro player

    [Header("Jump Properties")]
    public float jumpForce; // La potencia del salto
    public bool jumpInputOn; // He presionado el botón de salto?

    [Header("Ground Check Properties")]
    public Transform groundCheckPoint; //Punto para reconocer donde están los pies y ver el suelo.
    public float radius; //Radio para extender el rango del punto, y poder reconocer el suelo.
    public LayerMask whatIsGround; //Sirve para reconocer, ¿qué es tierra?
    public bool isGrounded; //Se vuelve true, en caso se haya tocado el suel, caso contrario, se vuelve false, puesto que estas en el aire.

    [Header("Animations")]
    public Animator animator;

    Vector2 inputValue; // Es para ver el input que estamos haciendo cuando presionamos los botones
                        // Registrados en Input.GetAxis o Input.GetAxisRaw

    void Start()
    {
        // Enlazar la variable rigidBody con el componente de mi player, RigidBody2D
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        // Llamar a la función MovementInput, donde mando el input a mi variable inputValue
        MovementInput();

        GroundCheck();

        //Si se presiona el botón space, se activa la variable jumpInputOn
        if (Input.GetKeyDown(KeyCode.Space))
            jumpInputOn = true;
    }

    private void FixedUpdate()
    {
        // Mover a mi player según el input registrado en la función MovementInput.
        MovementAction();

        //Si la variable JumpInputOn está activa (es true), entonces has el salto, y apaga la variable.
        if (jumpInputOn)
        {
            Jump();
            jumpInputOn = false;
        }
    }

    #region Movement
    void Movement_1()
    {
        if (Input.GetKey(KeyCode.A))
            direction = -1;
        else if (Input.GetKey(KeyCode.D))
            direction = 1;
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            direction = 0;

        rigidBody.velocity = new Vector2(direction * moveSpeed, rigidBody.velocity.y);

    }

    void MovementInput()
    {
        /*
         new Vector2(x,y) ->
         x (eje horizontal), le pasamos los valores que se obtienen al presionar un botón y multiplicando el valor de este por moveSpeed:
            Input.GetAxisRaw("Horizontal")*moveSpeed
        *NOTA: InputGetAxisRaw -> Si presiono alguno de los botónes registrados, me puede dar como valores -1 (a la izquierda) y 1 (a la derecha), y si no presiono nada 0
         
        y (eje vertical), es pasar la velocidad vertical de mi objeto, y esto se puede ver pensando en que le pasamos la gravedad.

        rigidBody.velocity.y -> pasar la gravedad.
         
         */
        inputValue = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rigidBody.velocity.y);

        if (inputValue.x > 0)
        {
            direction = 1;
            FlipSprite();
            //animator.SetBool("isMoving", true);
        }
        else if (inputValue.x < 0)
        {
            direction = -1;
            FlipSprite();
            //animator.SetBool("isMoving", true);
        }
        //else
        //{
        //    animator.SetBool("isMoving", false);
        //}

        animator.SetBool("isMoving", inputValue.x != 0 ? true : false);
    }

    void MovementAction()
    {
        //Aquí se pasan los valores que registramos en MovementInput, y se mandan al rigidbody, para que se mueva.
        rigidBody.velocity = inputValue;
    }

    #endregion

    #region Jump

    void GroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, radius, whatIsGround);
        animator.SetBool("isNotInGround", !isGrounded);
    }

    void Jump()
    {
        //Aquí se le da una fuerza en el eje y o en el eje vertical.
        if(isGrounded)
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
    }

    #endregion

    void FlipSprite()
    {
        /*
        //Forma A
        float rotation = 0;
        if (direction == 1)
            rotation = 180;
        else
            rotation = 0;

        //Forma B - Operadores Terciarios
        direction==1?180f:0;

        */
        transform.eulerAngles = new Vector3(0, direction == 1 ? 0f : 180, 0);
    }
}
