using System;


namespace ConsoleApplication1
{
    class LevelCreator
    {
		Level lev;
        public LevelCreator(Level lev)
		{
			this.lev = lev;
		}
		public Level GetLevel()
		{
			return lev;
		}

    }
	
	enum Level
	{
		Easy,
		Middle,
		Hard,
		Insanity
	}
	
}
