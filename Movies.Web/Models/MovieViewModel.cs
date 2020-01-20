using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Web.Models
{
	public class MovieViewModel
	{
		public string Title { get; set; }
		public string OriginalLanguage { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal VoteAverage { get; set; }
		public int Id { get; set; }
		public string Overview { get; set; }
	}
}
