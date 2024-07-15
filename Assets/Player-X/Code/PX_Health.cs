//------------
//... PLayer-X
//... V2.0.1
//... © TheFamousMouse™
//--------------------
//... Support email:
//... thefamousmouse.developer@gmail.com
//--------------------------------------

using UnityEngine;
using PlayerX;
using UnityEngine.UI;

namespace PlayerX
{
	public class PX_Health : MonoBehaviour
	{
		[Header("Player-X [Health]")]
		
		[Header("- Health Dependencies")]
		public PX_Dependencies dependencies;
		
		[Header("- Health")]
	    public float playerHealth = 100f;

		[Header("- UI")] 
		public Image healthBar;
		
		
		void LateUpdate()
		{
			//... Kill player if health depleted
			if(playerHealth <= 0f)
			{
				if (dependencies.state.isAlive)
				{
					Debug.Log("Player died");
				}
				
				dependencies.state.isAlive = false;
				dependencies.state.RagdollMode();
			}
			
			UpdateHealthBar(); 
		}
		
		public void TakeDamage(float damage)
		{
			playerHealth -= damage;
			Debug.Log("Player took damage: " + damage);
			Debug.Log("Player health: " + playerHealth);
			
			if (playerHealth < 0)
			{
				playerHealth = 0;
			}
			UpdateHealthBar();
		}

		private void UpdateHealthBar()
		{
			if (healthBar != null)
			{
				healthBar.fillAmount = playerHealth / 100f;
			}
		}
	}
}
