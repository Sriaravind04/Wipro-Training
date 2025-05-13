using System;

class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on social media");
    }
}

class Facebook : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

class Twitter : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

class Instagram : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main()
    {
        Facebook fb = new Facebook();
        Twitter tw = new Twitter();
        Instagram ig = new Instagram();

        fb.Post();
        tw.Post();
        ig.Post();
    }
}