using System;

// SOLID principles
// I - Interface Segregation Principle
// D - Dependency Inversion Principle



#region Interface Segregation Principle


namespace Lesson9_4
{
    public interface IAudioPlayer
    {
        void PlayAudio();
    }

    public interface IVideoPlayer
    {
        void PlayVideo();
    }

    public class DivMediaPlayer : IAudioPlayer, IVideoPlayer
    {
        public void PlayAudio() { Console.WriteLine("PlayAudio"); }
        public void PlayVideo() { Console.WriteLine("PlayVideo"); }
    }

    public class VlcMediaPlayer : IVideoPlayer
    {
        public void PlayVideo() { Console.WriteLine("PlayVideo"); }
    }

    public class WinampMediaPlayer : IAudioPlayer
    {
        public void PlayAudio() { Console.WriteLine("PlayAudio"); }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


#endregion



#region Dependency Inversion Principle

interface IDatabase
{
    void Create();
    void Read();
    void Update();
    void Delete();
}


class Oracle : IDatabase
{
    public void Create()
    {
        Console.WriteLine("Oracle Create");
    }

    public void Delete()
    {
        Console.WriteLine("Oracle Delete");
    }

    public void Read()
    {
        Console.WriteLine("Oracle Read");
    }

    public void Update()
    {
        Console.WriteLine("Oracle Update");
    }
}

class MongoDB : IDatabase
{
    public void Create()
    {
        Console.WriteLine("MongoDB Create");
    }

    public void Delete()
    {
        Console.WriteLine("MongoDB Delete");
    }

    public void Read()
    {
        Console.WriteLine("MongoDB Read");
    }

    public void Update()
    {
        Console.WriteLine("MongoDB Update");
    }
}



class Application
{
    private readonly IDatabase _database;

    public Application(IDatabase database)
    {
        _database = database;
    }

    public void Create()
    {
        _database.Create();
    }

    public void Delete()
    {
        _database.Delete();
    }

    public void Read()
    {
        _database.Read();
    }

    public void Update()
    {
        _database.Update();
    }
}



class Program
{
    static void Main2(string[] args)
    {
        //Application app = new Application(new Oracle());
        Application app = new Application(new MongoDB());
        app.Create();
    }
}

#endregion
