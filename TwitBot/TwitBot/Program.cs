using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TweetSharp;

namespace TwitBot
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("Press ESC to stop");

            //while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            //{
                
            while (true)
            {
            var lines = File.ReadAllLines("liners.txt");
            var rando = new Random();
            int randomLineNumber = rando.Next(0, lines.Length - 1);
            string line = lines[randomLineNumber];

            PostTweet(line);
            Thread.Sleep(60000);
            }

            


            //Console.WriteLine("Press any key to exit..."); 10 min

            //Console.ReadKey();
            



            //Timer t = new Timer(60000); // 1 sec = 1000, 60 sec = 60000

            //t.AutoReset = true;

            //t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

            //t.Start();


            //wait
            //string oneLiners;
            //using (StreamReader reader = new StreamReader("liners.txt"))
            //{
            //    oneLiners = reader.ReadLine();
            //}

        }
        //private static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
           


        //}

        static void getText()
        { 
        }

        static void PostTweet(string textToTweet)
        {
            var key = File.ReadAllLines("key.txt");
            string keyResult = string.Join("", key);
            var secret = File.ReadAllLines("secret.txt");
            string secretResult = string.Join("", secret);
            var service = new TwitterService(keyResult, secretResult);

            var token = File.ReadAllLines("Token.txt");
            string tokenResut = string.Join("", token);
            var tokenSecret = File.ReadAllLines("TokenSecret.txt");
            string tokenSecretResult = string.Join("", tokenSecret);
            service.AuthenticateWith(tokenResut, tokenSecretResult);


            SendTweetOptions tweet = new SendTweetOptions();
            tweet.Status = textToTweet;
            service.SendTweet(tweet);


        }

    }

}
