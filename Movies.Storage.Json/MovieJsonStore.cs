using Movies.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Storage.Json
{
	public class MovieJsonStore
	{
		List<MovieJson> _movies = null;

		public void LoadFromString(string moviesJson)
		{
			_movies = JsonConvert.DeserializeObject<List<MovieJson>>(moviesJson);
		}

		public int GetCount()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<MovieJson> FilterByOriginalLanguage(string languageCode)
		{
			return _movies.Where(m => m.OriginalLanguage == languageCode);
		}

		public IEnumerable<MovieJson> GetAll()
		{
			throw new NotImplementedException();
		}

		public MovieJson GetById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
