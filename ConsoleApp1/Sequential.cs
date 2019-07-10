namespace ConsoleApp1
{
    class Game : IGame, ICanKickAPlayer
    {
        public void Join(GamePlayer p)
        {
            throw new System.NotImplementedException();
        }

        public void Leave(GamePlayer p)
        {
            throw new System.NotImplementedException();
        }

        public void Kick(GamePlayer p)
        {
            throw new System.NotImplementedException();
        }
    }

    interface ICanKickAPlayer
    {
        void Kick(GamePlayer p);
    }

    interface IGame
    {
        void Join(GamePlayer p);
        void Leave(GamePlayer p);
    }

    internal class GamePlayer
    {
    }

    class Player
    {
        public void PlayNoiselessEchoyBass(string file)
        {
            var soundifier = new Soundifier();

            var sound = LoadSound(file);

            sound = soundifier.RemoveNoise(sound, 100);
            sound = soundifier.AddEcho(sound, 50);
            sound = soundifier.EnhanceBass(sound, 5);

            Play(sound);
        }

        private void Play(Sound sound)
        {
            //Logic which plays sound
        }

        private Sound LoadSound(string file)
        {
            return new Sound();
        }
    }

    //This class is sequentially cohesive
    class Soundifier
    {
        public Sound AddEcho(Sound sound, int delay)
        {
            //Logic to add and echo to the sound
            return sound;
        }

        public Sound EnhanceBass(Sound sound, int frequency)
        {
            //Logic to add and more bass
            return sound;
        }

        public Sound RemoveNoise(Sound sound, int aggression)
        {
            //Logic clean the sound
            return sound;
        }
    }

    public class Sound
    {
        //Some awesome logic that digitally represents sound!
    }
}