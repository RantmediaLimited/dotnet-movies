using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core
{
	public class MovieService : IMovieService
	{
		public Task EmailMovieDetailsAsync(int movieId, string toEmailAddress)
		{
			throw new NotImplementedException();
		}
	}
}
