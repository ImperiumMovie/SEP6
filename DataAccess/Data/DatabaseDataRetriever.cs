﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.DBContext;
using Domain;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class DatabaseDataRetriever : IDatabaseRetriever
    {
        private DbContextOptions<ImperiumDBContext> options;

        public DatabaseDataRetriever()
        {
            options = new DbContextOptionsBuilder<ImperiumDBContext>()
                .UseSqlServer("Server=tcp:imperiummovie.database.windows.net,1433;Initial Catalog=ImpMovieDB;Persist Security Info=False;User ID=CloudSAf3b22f19;Password=m_SCPkB]3\"YZ=*@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
                .Options;
        }

        public async Task<User> RegisterUser(User user)
        {
            using var context = new ImperiumDBContext(options);
            MovieList movieList = new MovieList();
            movieList.MovieListID = GenerateNewMovieListId();
            user.MovieList = movieList;
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<User> LogIn(string username, string password)
        {
            await using var context = new ImperiumDBContext(options);
            return await context.Users.Include(m => m.MovieList).FirstOrDefaultAsync(m => m.Username.Equals(username) && m.Password.Equals(password));
        }

        public async Task<Movie> GetMovie(int id)
        {
            await using var context = new ImperiumDBContext(options);
            return await context.Movie.FindAsync(id);
        }

        public async Task<MovieList> GetMovieList(int movieListId)
        {
            using var context = new ImperiumDBContext(options);
            var movieList = await context.MovieList.Include(m => m.Movies).FirstOrDefaultAsync(m => m.MovieListID == movieListId);
            return movieList;
        }

        public async Task<List<MovieList>> GetMovieLists()
        {
            using var context = new ImperiumDBContext(options);
            return context.MovieList.Include(m => m.Movies).ToList();
        }

        public async Task AddMovie( Movie movie)
        {
            using var context = new ImperiumDBContext(options);
            context.Movie.Add(movie);
            await context.SaveChangesAsync();
        }

        public async Task RemoveMovie(int movieId)
        {
            using var context = new ImperiumDBContext(options);
            Movie movie = await context.Movie.FirstAsync(m => m.MovieID == movieId);
            context.Movie.Remove(movie);
            await context.SaveChangesAsync();

        }

        private int GenerateNewMovieListId()
        {
            using var context = new ImperiumDBContext(options);
            int newId;

            do
            {
                newId = new Random().Next(100000, 999999);
            } while (context.MovieList.Any(m => m.MovieListID == newId));

            return newId;
        }
    }
}