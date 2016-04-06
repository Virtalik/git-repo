using System;


namespace ConsoleApplication1
{
    class LevelCreator
    {
		Level lev;
        LevelCreator(Level lev)
		{
			this.lev = lev;
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
