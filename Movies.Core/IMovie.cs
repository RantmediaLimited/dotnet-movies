using System;
using System.Collections.Generic;

namespace Movies.Core
{
	public interface IMovie
	{
		int Id { get; }
		int VoteCount { get; }
		bool IsVideo { get; }
		decimal VoteAverage { get; }
		string Title { get; }
		decimal Popularity { get; }
		string PosterPath { get; }
		string OriginalLanguage { get; }
		string OriginalTitle { get; }
		IList<int> GenreIds { get; }
		string BackdropPath { get; }
		bool IsAdult { get; }
		string Overview { get; }
		DateTime ReleaseDate { get; }
	}
}
