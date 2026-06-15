using UnityEngine;

public class PlayerPUSHPULL : MonoBehaviour
{
    public float distance = 1f;
    public LayerMask boxMask;
    GameObject box;

    void Start()
    {

    }

    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, distance, boxMask);

        if (hit.collider != null && hit.collider.gameObject.tag == "pushable" && Input.GetKeyDown(KeyCode.E))
        {
            if (box != null)
            {
                box.GetComponent<FixedJoint2D>().enabled = false;
            }

            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            if (box != null)
            {
                box.GetComponent<FixedJoint2D>().enabled = false;
                box = null;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + (Vector2)transform.right * distance);
    }
}