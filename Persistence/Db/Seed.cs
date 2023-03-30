
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace Persistence.Db;

public static class Seed
{
    public static async Task SeedData(this ModelBuilder modelBuilder, UserManager<AppUser> userManager)
    {
        List<AppUser> users = new()
        {
            new AppUser { DisplayName = "Bob", UserName = "bob", Email = "bob@test.com", Bio = "Bob"},
            new AppUser { DisplayName = "Tom", UserName = "tom", Email = "tom@test.com", Bio = "Tom"},
            new AppUser { DisplayName = "Jane", UserName = "jane", Email = "jane@test.com", Bio = "Jane"}
        };

        if (!userManager.Users.Any())
        {
            foreach (AppUser user in users)
            {
                await userManager.CreateAsync(user, "Test$user11");
            }
        }

        Guid idNew = new Guid("1301565a-484b-4039-8bce-4ae2cc3342eb");
        modelBuilder.Entity<Activity>().HasData(
                new Activity
                {
                    Id = idNew,
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Attendees = new List<ActivityAttendee>
                        {
                            new ActivityAttendee
                            {
                                ActivityId = idNew,
                                AppUser = users[0],
                                IsHost = true
                            }
                        }
                }
                /*
                new Activity
                {
                    Id = new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"),
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "The Louvre",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"),
                            AppUser = users[0],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"),
                            AppUser = users[1],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("398cba62-4b07-4c11-973a-1205db025fc0"),
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "music",
                    City = "London",
                    Venue = "Wembly Stadium",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("398cba62-4b07-4c11-973a-1205db025fc0"),
                            AppUser = users[2],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("398cba62-4b07-4c11-973a-1205db025fc0"),
                            AppUser = users[1],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"),
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months in future",
                    Category = "food",
                    City = "London",
                    Venue = "Jamies Italian",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"),
                            AppUser = users[0],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"),
                            AppUser = users[2],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"),
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"),
                            AppUser = users[1],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"),
                            AppUser = users[0],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("8a367040-95fc-4fff-875c-ec5c5354056f"),
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months in future",
                    Category = "culture",
                    City = "London",
                    Venue = "British Museum",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("8a367040-95fc-4fff-875c-ec5c5354056f"),
                            AppUser = users[1],
                            IsHost = true
                        }
                    }
                },
                new Activity
                {
                    Id = new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"),
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Punch and Judy",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"),
                            AppUser = users[0],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"),
                            AppUser = users[1],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"),
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"),
                            AppUser = users[2],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"),
                            AppUser = users[1],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"),
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 7 months in future",
                    Category = "travel",
                    City = "Berlin",
                    Venue = "All",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"),
                            AppUser = users[0],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"),
                            AppUser = users[2],
                            IsHost = false
                        },
                    }
                },
                new Activity
                {
                    Id = new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"),
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Attendees = new List<ActivityAttendee>
                    {
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"),
                            AppUser = users[2],
                            IsHost = true
                        },
                        new ActivityAttendee
                        {
                            ActivityId = new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"),
                            AppUser = users[1],
                            IsHost = false
                        },
                    }
                }*/
            );
    }
  
    /*
    public static async Task SeedUserData(UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            List<AppUser> appUsers = new()
            {
                new AppUser { DisplayName = "Bob", UserName = "bob", Email = "bob@test.com", Bio = "Bob"},
                new AppUser { DisplayName = "Tom", UserName = "tom", Email = "tom@test.com", Bio = "Tom"},
                new AppUser { DisplayName = "Jane", UserName = "jane", Email = "jane@test.com", Bio = "Jane"}
            };

            foreach (AppUser user in appUsers)
            {
                await userManager.CreateAsync(user, "Test$user11");
            }
        }
    }
    */
}
