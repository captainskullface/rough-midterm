
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }

    private Rigidbody2D body;
    public float speed;
    public float jump;
    public static bool hasPizza;
    public int Money;

    public bool tMove;
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector2(0, jump));
            //body.velocity = new Vector2(body.velocity.x, jump);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interactable?.Interact(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tony")
        {
            tMove = true;
        }
    }

}
