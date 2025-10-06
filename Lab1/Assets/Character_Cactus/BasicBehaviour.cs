using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBehaviour : MonoBehaviour
{
    private Animator mAnimator;
    private GameObject obj1, obj2;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        obj1 = GameObject.Find("Cactus");
        obj2 = GameObject.Find("Cactus2");
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if(obj1!=null && obj2 != null)
            {
                distance=Vector3.Distance(obj1.transform.position,obj2.transform.position);
                if (distance < 0.25)
                {
                    mAnimator.SetTrigger("Attack");
                }
                else
                {
                    mAnimator.SetTrigger("StopAttacking");
                }
            }
        }
    }
}
