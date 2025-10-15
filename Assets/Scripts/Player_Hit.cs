using UnityEngine;

public class Player_Hit : MonoBehaviour
{
    public Animator anim;

    public void Attack()
    {
        anim.SetBool("isPunching", true);
    }

}
