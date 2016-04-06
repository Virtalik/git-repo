using System;


namespace ConsoleApplication1
{
    class LevelCreator
    {
		Level Lev;
        public LevelCreator(Level Lev)
		{
			this.Lev = Lev;
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
