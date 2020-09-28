using BlazingGoMemory.Shared.Interfaces;
//using GoMemory.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Drawing;
using System.Threading.Tasks;
using BlazingGoMemory.Shared.Models;
using System.IO.Pipes;

namespace BlazingGoMemory.Client.Helpers
{
       public static class TokenHelper 
       {
             
        public static List<Token> GetAllTokens()
        {   
            List<string> TokenCollection = new List<string>
            {
                   "apple.png",
                    "beer.png",
                    "bell.png",
                    "bison.png",
                    "cake.png",
                    "camera.png",
                   "carrot.png",
                    "cheese.png",
                    "chocolate.png",
                    "clock.png",
                    "codfish.png",
                    "crab.png",
                    "egg.png",
                    "frog.png",
                    "hammer.png",
                    "lightbulb.png",
                    "lightning.png",
                    "lolly.png",
                    "microphone.png",
                    "milkshake.png",
                    "orange.png",
                    "parrot.png",
                    "phone.png",
                    "pig.png",
                    "portobello.png",
                    "rabbit.png",
                    "robots.png",
                    "sausage.png",
                    "scissors.png",
                    "spider.png",
                    "star.png",
                    "strawberry.png",
                    "teapot.png",
                    "wasp.png",
                    "watermelon.png",
                    "wine.png"
    };
    
            List<Token> tokens = new List<Token>();
            //Temporary generation
            foreach (var img in TokenCollection)
            {
                tokens.Add(new Token
                {
                    Source = $"../images/{img}",
                    Name = img.Replace(".png", string.Empty)
                });
            }
            return tokens;
        }
        
       
        //public List<Token> GetShuffledTokens(int totalTokens) =>
        //    ShuffleCollection(_tokens).Take(totalTokens).ToList(); 
        
        public static List<Token> ToMatchTokenList(int numberOfTokensNeeded, List<Token> tokens) =>
            ShuffleCollection(tokens).Take(numberOfTokensNeeded).ToList();

        public static List<Token> ShuffleCollection(List<Token> tokens)
        {
            Random rnd = new Random();            
            for (int i = 0; i < tokens.Count; i++)
            {
                Token temp = tokens[i];
                int randomIndex = rnd.Next(0, tokens.Count);
                tokens[i] = tokens[randomIndex];
                tokens[randomIndex] = temp;
            }
            return tokens;
        }



       
      
        


    }
}

