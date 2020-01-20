using Movies.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Movies.Storage.Json
{
	public class MovieJson
	{
		public int Id { get; set; }

		[JsonProperty(PropertyName ="vote_count")]
		public int VoteCount { get; set; }

		[JsonProperty(PropertyName ="video")]
		public bool IsVideo { get; set; }

		[JsonProperty(PropertyName = "vote_average")]
		public decimal VoteAverage { get; set; }

		public string Title { get; set; }

		public decimal Popularity { get; set; }

		[JsonProperty(PropertyName ="poster_path")]
		public string PosterPath { get; set; }

		[JsonProperty(PropertyName ="original_language")]
		public string OriginalLanguage { get; set; }

		[JsonProperty(PropertyName ="original_title")]
		public string OriginalTitle { get; set; }

		[JsonProperty(PropertyName ="genre_ids")]
		public IList<int> GenreIds { get; set; }

		[JsonProperty(PropertyName ="backdrop_path")]
		public string BackdropPath { get; set; }

		[JsonProperty(PropertyName ="adult")]
		public bool IsAdult { get; set; }

		public string Overview { get; set; }

		[JsonProperty(PropertyName ="release_date")]
		public DateTime ReleaseDate { get; set; }
	}
}
