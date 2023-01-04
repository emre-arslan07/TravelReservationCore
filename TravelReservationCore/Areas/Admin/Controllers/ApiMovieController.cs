﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TravelReservationCore.Areas.Admin.Models;

namespace TravelReservationCore.Areas.Admin.Controllers
{	
    [Area("Admin")]
	[AllowAnonymous]
	public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
			List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "2d14bd3aa9msh222fbe8f0a3de98p12c8c6jsn217f32bc5c5c" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
				return View(apiMovies);
			}
			
        }
    }
}
