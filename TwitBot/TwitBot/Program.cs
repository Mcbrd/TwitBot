using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace TwitBot
{
    class Program
    {
        static string tweetText = "";


        static void Main(string[] args)
        {
            PostTweet("Hello World");
        }
        static void PostTweet(string textToTweet)
        {
            var service = new TwitterService("ConsumerKey, "ConsumerSecret");
            service.AuthenticateWith("AccessToken", "AccessTokenSecret");
            SendTweetOptions tweet = new SendTweetOptions();
            tweet.Status = textToTweet;

            service.SendTweet(tweet);


        }

    }

}
