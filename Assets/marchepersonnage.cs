using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marchepersonnage : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed=5f;
    Rigidbody2D rb;
    void Start()
    {
      rb =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        Vector2 move=new Vector2(moveHorizontal,moveVertical);
        rb.velocity=move*speed ;
    }
}
