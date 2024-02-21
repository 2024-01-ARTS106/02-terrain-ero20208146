using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGOimput : MonoBehaviour
{
    [SerializeField] float horizontalMove;
    [SerializeField] float verticalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(horizontalMove, 0, verticalMove);
        
    }
}
