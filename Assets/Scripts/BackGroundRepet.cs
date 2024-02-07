
using UnityEngine;

public class BackGroundRepet : MonoBehaviour
{
    private float spriteWitdth;
    void Start()
    {
        BoxCollider2D boxCollider = GetComponent<BoxCollider2D>();
        spriteWitdth = boxCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -spriteWitdth)
        {
            ResetPosition();
        }
    }
    private void ResetPosition()
    {
        transform.Translate(new Vector3(2* spriteWitdth,0f,0f));
    }
}
