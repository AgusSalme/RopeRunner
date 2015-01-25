using UnityEngine;
using System.Collections;

public class PlayerControllerGrid : MonoBehaviour {
	
	public Vector2 pos;
	public bool moving = false;
	public PlayerControllerGrid otherPlayer;
	public int playerId;
	Animator anim;
	public bool hit;

	
	void Start () {
		// First store our current position when the
		// script is initialized.
		pos = transform.position;
		hit = false;
	}
	
	void Update () {
		if (otherPlayer.hit) {
			if (moving && ValidateMovement ()) {
				// pos is changed when there's input from the player
				CheckBounds ();
				transform.position = pos;
				moving = false;
			}
		}
		else if (!hit) {
			CheckInput ();

			if (moving && ValidateMovement ()) {
					// pos is changed when there's input from the player
					CheckBounds ();
					transform.position = pos;
					moving = false;
			}
		} 
	}
	private void CheckBounds(){
		if(pos.x > GameManager.gamemanager.levelEnd)pos.x = GameManager.gamemanager.levelEnd;
		if(pos.x < GameManager.gamemanager.levelBegin)pos.x = GameManager.gamemanager.levelBegin;
	}

	private bool ValidateMovement(){
		float dif = pos.x - otherPlayer.transform.position.x;
		float multiplier = GameManager.gamemanager.ropeLenght / 2;
		if(dif == 0){
			if(transform.position.x - otherPlayer.transform.position.x <= 0){
				pos -= Vector2.right*multiplier;
				otherPlayer.pos += Vector2.right*multiplier;
				otherPlayer.moving = true;
			}else{
				pos += Vector2.right*multiplier;
				otherPlayer.pos -= Vector2.right*multiplier;
				otherPlayer.moving = true;
			}
			hit = true;
			Invoke("EnableMovement",0.3f);
			return true;
		}

		else if (Mathf.Abs(dif) > GameManager.gamemanager.ropeLenght) {
			pos = transform.position;
			return false;
		}
		return true;
	}
	private void EnableMovement(){
		hit = false;
		otherPlayer.hit = false;
	}
	private void CheckInput() {
		
		// WASD control
		// We add the direction to our position,
		// this moves the character 1 unit (32 pixels)
		if (Input.GetButton("Player" + playerId + "Right")) {
		//if (Input.GetButtonUp("Player" + playerId + "Right")) {
			pos += Vector2.right;
			moving = true;
		//	anim.SetBool("PersonajeRight" + playerId, true);
		}
		
		// For left, we have to subtract the direction
		else if (Input.GetButton("Player" + playerId + "Left")){
		//else if (Input.GetButtonUp("Player" + playerId + "Left")){
			pos -= Vector2.right;
			moving = true;
		//	anim.SetBool("PersonajeLeft" + playerId, true);
		}
		
	}
}
