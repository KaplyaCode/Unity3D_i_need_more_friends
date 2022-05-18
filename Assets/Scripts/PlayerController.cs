using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveOnHorizontal;                     //тригер для поворота в левую сторону

    public AudioClip[] footsteps;                       //масив с шагами

    AudioSource playerAudio;

    private Rigidbody2D rb;                             //для получения физики 2д
    private Vector2 moveVelocity;                       //для перемещения в пространстве

    private bool facingRight = true;                    //для поворота

    void Start(){
        rb = GetComponent<Rigidbody2D>();

        playerAudio = GetComponent<AudioSource>();
    }

    void Update(){
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));  //вычисление перемещений
        moveVelocity = moveInput.normalized * speed;    //фиксация перемещений

        if(Input.GetKey(KeyCode.Escape)){               //выход в меню
        SceneManager.LoadScene("MainMenu");
        }
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);  //перемещение

        moveOnHorizontal = Input.GetAxis("Horizontal");    //получение вектора движения по горизонтали

        if (facingRight == false && moveOnHorizontal > 0){
            Flip();
        }else if (facingRight == true && moveOnHorizontal < 0){
            Flip();
        }
    }

    void Flip(){                                            //переворот в лево
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void FootSteps(){
        int randInt = Random.Range(0, footsteps.Length);    //рандомит звук шага из масива
        playerAudio.pitch = Random.Range(0.7f, 1.1f);
        playerAudio.PlayOneShot(footsteps[randInt]);
    }
}
