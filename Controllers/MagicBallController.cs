// Daniel Decoito
// 10-27-22
// Mini Challenge: Magic 8 Ballin
// use webapi to return a random phrase
// peer reviewed by: Mark A Ramirez not much to say other than it works and it works consistantly.

using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_Magic8Ball.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicBallController : ControllerBase
{

[HttpGet]
[Route("Game")]

public string Game()
{
   string [] randomPhrase = new string [] {"Outlook not so good", "Ask again Later", "Go for it", "Consider an alternative", "Dont just dont", "Get Bent", "Thats gross your even thinking that", "Just do it", "Eat all the babies", "Who even reads this" }; 
    
    Random num = new Random();
    int guessNum = num.Next(0,9);
    
    
     return randomPhrase[guessNum];

}





  
}
