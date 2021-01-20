using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D _rigidBody;
    private Vector3 _change;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _change = Vector3.zero;
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {        
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimation();

    }

    void MoveCharacter()
    {        
        _rigidBody.MovePosition(transform.position + (_change * speed * Time.deltaTime));
    }

    void UpdateAnimation()
    {
        if (_change != Vector3.zero)
        {
            MoveCharacter();
            _animator.SetFloat("moveX", _change.x);
            _animator.SetFloat("moveY", _change.y);
            _animator.SetBool("moving", true);
        }
        else
        {
            _animator.SetBool("moving", false);
        }
    }
}
