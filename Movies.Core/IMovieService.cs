using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core
{
	public interface IMovieService
	{
		Task EmailMovieDetailsAsync(int movieId, string toEmailAddress);
	}
}
