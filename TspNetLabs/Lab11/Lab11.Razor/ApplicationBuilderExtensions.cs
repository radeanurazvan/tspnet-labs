using System;
using Lab11.Razor.Data;
using Lab11.Razor.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Lab11.Razor
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSeedData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<Lab11RazorContext>();
                if (context.Track.Any())
                {
                    return app;
                }

                context.Track.Add(new Track
                {
                    Title = "Level of concern",
                    Artist = "21 pilots",
                    Album = "Dunno",
                    ReleaseDate =  DateTime.Now.AddYears(-1),
                    Duration = new TimeSpan(0, 3, 14)
                });

                context.Track.Add(new Track
                {
                    Title = "Tear in my heart",
                    Artist = "21 pilots",
                    Album = "Dunno",
                    ReleaseDate = DateTime.Now.AddYears(-2),
                    Duration = new TimeSpan(0, 4, 20)
                });

                context.Track.Add(new Track
                {
                    Title = "November rain",
                    Artist = "Guns n roses",
                    Album = "Dunno",
                    ReleaseDate = DateTime.Now.AddYears(-10),
                    Duration = new TimeSpan(0, 8, 20)
                });

                context.SaveChanges();
                return app;
            }
        }
    }
}