using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.Storage.Json;
using Movies.Web.App_Data;
using Movies.Web.Models;

namespace Movies.Web.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Index()
		{
			var movieStore = new MovieJsonStore();

			movieStore.LoadFromString(MovieResources.movies);

			var models = movieStore.GetAll()
				.Select(m =>
					new MovieViewModel
					{
						Id = m.Id,
						Title = m.Title,
						OriginalLanguage = m.OriginalLanguage,
						ReleaseDate = m.ReleaseDate,
						VoteAverage = m.VoteAverage,
						Overview = m.Overview
					}).ToList();

			return View(models);
		}

		public IActionResult Details(int id)
		{
			var movieStore = new MovieJsonStore();

			movieStore.LoadFromString(MovieResources.movies);

			var movie = movieStore.GetById(id);
			var model = new MovieViewModel
				{
					Id = movie.Id,
					Title = movie.Title,
					OriginalLanguage = movie.OriginalLanguage,
					ReleaseDate = movie.ReleaseDate,
					VoteAverage = movie.VoteAverage
				};

			return View(model);
		}

		public IActionResult EmailMovieDetails(int id, string email)
		{
			return Ok();
			//throw new NotImplementedException();
		}
	}
}
