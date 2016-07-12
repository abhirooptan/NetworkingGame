using UnityEngine;
using System.Collections;

public class SwordAnim : StateMachineBehaviour {

    private GameObject weapon;
    Animator anim;

    void Start()
    {
            
    }

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        weapon = GameObject.FindGameObjectWithTag("Weapon");
        weapon.GetComponent<MeshCollider>().enabled = true;
	}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        weapon.GetComponent<MeshCollider>().enabled = false;
        animator.SetBool("Attack1Bool", false);
        animator.SetBool("Attack2Bool", false);
        animator.SetBool("Attack3Bool", false);
        animator.SetBool("Attack4Bool", false);

    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
