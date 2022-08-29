 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsManager : MonoBehaviour
{
    [SerializeField] private GameObject Gun;


    public static GunsManager instance;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */
}
