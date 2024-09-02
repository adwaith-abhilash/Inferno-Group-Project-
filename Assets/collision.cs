using UnityEngine;
public class collision : MonoBehaviour
{
    void OnCollisionEnter(Collision collider)
    {
        Debug.Log("Enter");
    }
    void OnCollisionExit(Collision collider)
    {
        Debug.Log("Exit");
    }
} 
