using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core
{
	public class MovieEmailer
	{
		public async Task EmailMovieDetailsAsync(IMovie movie, string toEmailAddress)
		{
			//Pretending to email
			Task.Delay(500).Wait();
		}
	}
}
