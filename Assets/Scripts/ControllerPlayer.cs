
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public bool PuedeSaltar = false;
    public float fuerzaDeSalto = 10.0f;
    public Animator _Animator;
    public Vector2 miPosicion;
    public bool obstacle;
    public float translate;
    public GameObject PanelOver;

    
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        _Animator = GetComponent<Animator>();
        miPosicion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PuedeSaltar && Input.GetKeyDown(KeyCode.Space)) 
        {
            Rigidbody2D.AddForce(Vector2.up * fuerzaDeSalto, ForceMode2D.Impulse);
            _Animator.SetBool("Salto", true);

        }

        if (obstacle)
        {
            StartCoroutine(TranslatePosicion());
        }

        if (transform.position.x >= miPosicion.x)
        {
            transform.position = new Vector3(miPosicion.x, transform.position.y, transform.position.z);
        }



    }
    
    
    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.CompareTag("Floor")) 
        {
            PuedeSaltar = true;
            _Animator.SetBool("Salto", false);
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _Animator.SetBool("Choque", true);
            StartCoroutine(QuitarChoque());
            obstacle = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            PanelOver.SetActive(true);
        }

    }
    IEnumerator QuitarChoque()
    {
        yield return new WaitForSeconds(1);
        _Animator.SetBool("Choque", false);
    }

    void OnCollisionExit2D (Collision2D collision) {
        if (collision.gameObject.CompareTag("Floor")) 
        {
            PuedeSaltar = false;

        }
    }

    IEnumerator TranslatePosicion()
    {
        yield return new WaitForSeconds(2);
        
        
        transform.Translate(miPosicion * translate * Time.deltaTime);
    
    }
}
