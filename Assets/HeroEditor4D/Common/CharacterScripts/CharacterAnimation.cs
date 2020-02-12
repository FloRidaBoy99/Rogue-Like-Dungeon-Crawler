using System;
using Assets.HeroEditor4D.Common.CommonScripts.Springs;
using HeroEditor.Common.Enums;
using UnityEngine;

namespace Assets.HeroEditor4D.Common.CharacterScripts
{
	/// <summary>
	/// Used to play animations.
	/// </summary>
	public class CharacterAnimation : MonoBehaviour
	{
		public Character4D Character;
		public Animator Animator;

        /// <summary>
        /// Set animation parameter State that controls transition.
        /// </summary>
		public void SetState(CharacterState state)
		{
			Animator.SetInteger("State", (int) state);
		}

        /// <summary>
        /// Play Attack animation according to selected weapon.
        /// </summary>
		public void Attack()
		{
			switch (Character.WeaponType)
			{
				case WeaponType.Melee1H:
				case WeaponType.Melee2H:
					Slash1H();
					break;
				case WeaponType.Bow:
					ShotBow();
					break;
				default:
					throw new NotImplementedException("This feature may be implemented in next updates.");
			}
		}

        /// <summary>
        /// Play Slash1H animation.
        /// </summary>
		public void Slash1H()
		{
			Animator.SetTrigger("Slash1H");
		}

        /// <summary>
        /// Play Stab animation.
        /// </summary>
        public void Stab()
        {
            Animator.SetTrigger("Stab");
        }

        /// <summary>
        /// Play Slash1H animation.
        /// </summary>
        public void PowerSlash1H()
        {
            Animator.SetTrigger("PowerSlash1H");
        }
        
	    /// <summary>
	    /// Play PowerStab animation.
	    /// </summary>
	    public void PowerStab()
	    {
	        Animator.SetTrigger("PowerStab");
	    }

        /// <summary>
        /// Play Shot animation (bow).
        /// </summary>
		public void ShotBow()
		{
			Animator.SetTrigger("ShotBow");
		}

        /// <summary>
        /// Play Death animation.
        /// </summary>
	    public void Die()
	    {
	        SetState(CharacterState.Death);
	    }

        /// <summary>
        /// Play Hit animation. This will just scale character up and down.
        /// Hit will not break currently playing animation, for example you can Hit character while it's playing Attack animation.
        /// </summary>
	    public void Hit()
	    {
	        Animator.SetTrigger("Hit");
        }

	    public void ShieldBlock()
	    {
	        SetState(CharacterState.ShieldBlock);
        }

	    public void WeaponBlock()
	    {
	        SetState(CharacterState.WeaponBlock);
	    }

        /// <summary>
        /// Alternative way to Hit character (with a script).
        /// </summary>
	    public void Spring()
	    {
            ScaleSpring.Begin(this, 1f, 1.1f, 40, 2);
        }
    }
}