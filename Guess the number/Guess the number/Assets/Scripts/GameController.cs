using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;


public class GameController : MonoBehaviour
{
  
  private int num;
  private int counter;

  [SerializeField]
  private InputField input;

   [SerializeField]
  private Text text;

  [SerializeField]
  private GameObject btn;

  public void Awake(){
      num = Random.Range(0, 100);
      text.text = "Guess a number between  0 and 100";
  } 
  public void GetInput(string param){ 
    CompareGuesses(int.Parse(param));
      input.text = "";
      counter++;
  } 
  public void CompareGuesses(int guess){

    if(guess == num){
      text.text = "You guessed correctly. The number was " + guess + ". It took you " + counter + " try(es). Do you want to play again ? ";
      btn.SetActive(true);
    } else if(guess < num ){
      text.text = "Your guess was lesser than the number you are trying to guess";
    } else if(guess > num){
      text.text = "Your guess was greater  than the number you are trying to guess";
    } 

  } 

  public void PlayAgain(){
    Awake();
    counter = 0;
    btn.SetActive(false); 
  }
}
