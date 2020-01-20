using Movies.Storage.Json.Tests.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Movies.Storage.Json.Tests
{
	public class MovieJsonStoreTests
	{
		readonly string _movieJsonData;

		public MovieJsonStoreTests()
		{
			_movieJsonData = TestResources.movies;
		}

		[Fact]
		public void GivenJsonStringOfMovies_WhenConstructed_ThenCountIsCorrect()
		{
			var movieStore = new MovieJsonStore();
			movieStore.LoadFromString(_movieJsonData);

			Assert.Equal(200, movieStore.GetCount());
		}

		[Fact]
		public void GivenDataLoaded_WhenFilteredByOriginalLanguage_ThenCorrectNumberOfItemsReturned()
		{
			var movieStore = new MovieJsonStore();
			movieStore.LoadFromString(_movieJsonData);

			var englishMovies = movieStore.FilterByOriginalLanguage("JA").ToList();

			Assert.Equal(4, englishMovies.Count);
		}

		[Fact]
		public void GivenDataLoaded_WhenMovieGotById_ThenCorrectMovieReturned()
		{
			var movieStore = new MovieJsonStore();
			movieStore.LoadFromString(_movieJsonData);

			var movie = movieStore.GetById(424694);

			Assert.Equal(424694, movie.Id);
			Assert.Equal("Bohemian Rhapsody", movie.Title);
		}
	}
}
