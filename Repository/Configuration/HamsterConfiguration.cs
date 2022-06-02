using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class HamsterConfiguration : IEntityTypeConfiguration<Hamster>
    {
        public void Configure(EntityTypeBuilder<Hamster> builder)
        {
            builder.HasData
            (
            new Hamster
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5244280c2ce3"),
                Name = "Haskel",
                Age = 1,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-1.jpg",
                Wins = 39,
                Defeats = 32,
                Games = 71,
                Likes = 348,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280c2ce3"),
                Name = "Shanon",
                Age = 1,
                FavouriteFood = "Beaver",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-2.jpg",
                Wins = 95,
                Defeats = 29,
                Games = 124,
                Likes = 553,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2ce3"),
                Name = "Jedediah",
                Age = 0,
                FavouriteFood = "Chestnut",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-3.jpg",
                Wins = 89,
                Defeats = 8,
                Games = 97,
                Likes = 595,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94aa-4d15-9494-5244280a2ae3"),
                Name = "Ruttger",
                Age = 1,
                FavouriteFood = "Cow",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-4.jpg",
                Wins = 84,
                Defeats = 82,
                Games = 166,
                Likes = 38,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2aa3"),
                Name = "Eleanor",
                Age = 2,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-5.jpg",
                Wins = 80,
                Defeats = 35,
                Games = 115,
                Likes = 689,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9794-5244280a2ab3"),
                Name = "Aggi",
                Age = 2,
                FavouriteFood = "Skunk",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-6.jpg",
                Wins = 53,
                Defeats = 56,
                Games = 109,
                Likes = 690,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3f590a70-94ce-4d15-9494-5244280a2ac3"),
                Name = "Wally",
                Age = 2,
                FavouriteFood = "Sloth",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-7.jpg",
                Wins = 50,
                Defeats = 105,
                Games = 155,
                Likes = 394,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d890a70-94ce-4d15-9494-5244280a2ad3"),
                Name = "Jackquelin",
                Age = 3,
                FavouriteFood = "Frogmouth",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-8.jpg",
                Wins = 25,
                Defeats = 69,
                Games = 94,
                Likes = 748,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590e70-94ce-4d15-9494-5244280a2ae3"),
                Name = "Rick",
                Age = 2,
                FavouriteFood = "Jaguar",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-9.jpg",
                Wins = 55,
                Defeats = 22,
                Games = 77,
                Likes = 990,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d598a70-94cf-4d15-9494-5244280a2af3"),
                Name = "Tova",
                Age = 3,
                FavouriteFood = "Caribou",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-10.jpg",
                Wins = 24,
                Defeats = 4,
                Games = 28,
                Likes = 133,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a74-94ce-4d15-9494-5244280a2ba3"),
                Name = "Bogart",
                Age = 2,
                FavouriteFood = "Owl",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-11.jpg",
                Wins = 35,
                Defeats = 24,
                Games = 59,
                Likes = 945,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-5d15-9494-5244280a2bb3"),
                Name = "Gregorius",
                Age = 3,
                FavouriteFood = "Snake",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-12.jpg",
                Wins = 65,
                Defeats = 37,
                Games = 102,
                Likes = 619,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5245280a2bc3"),
                Name = "Vevay",
                Age = 2,
                FavouriteFood = "Warthog",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-13.jpg",
                Wins = 17,
                Defeats = 12,
                Games = 29,
                Likes = 889,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-64ce-4d15-9494-5244280a2be3"),
                Name = "Danny",
                Age = 1,
                FavouriteFood = "Boar",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-14.jpg",
                Wins = 8,
                Defeats = 44,
                Games = 52,
                Likes = 93,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d990a70-94ce-4d15-9494-5244280a2bf3"),
                Name = "Davide",
                Age = 3,
                FavouriteFood = "Iguana",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-15.jpg",
                Wins = 99,
                Defeats = 23,
                Games = 122,
                Likes = 627,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9094-5244280a2ca3"),
                Name = "Mariellen",
                Age = 2,
                FavouriteFood = "Hoffman",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-16.jpg",
                Wins = 45,
                Defeats = 51,
                Games = 96,
                Likes = 291,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94be-4d15-9494-5244280a2cb3"),
                Name = "Kittie",
                Age = 3,
                FavouriteFood = "Koala",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-17.jpg",
                Wins = 59,
                Defeats = 45,
                Games = 104,
                Likes = 496,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2cc3"),
                Name = "Steffi",
                Age = 3,
                FavouriteFood = "Eagle",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-18.jpg",
                Wins = 20,
                Defeats = 91,
                Games = 111,
                Likes = 329,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2ce3"),
                Name = "Phedra",
                Age = 0,
                FavouriteFood = "Duck",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-19.jpg",
                Wins = 11,
                Defeats = 39,
                Games = 50,
                Likes = 26,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590e70-94ce-4d15-9494-5244280a2cf3"),
                Name = "Artemas",
                Age = 2,
                FavouriteFood = "Squirrel",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-20.jpg",
                Wins = 97,
                Defeats = 91,
                Games = 188,
                Likes = 598,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2da3"),
                Name = "Lilla",
                Age = 1,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-21.jpg",
                Wins = 65,
                Defeats = 74,
                Games = 139,
                Likes = 252,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2db3"),
                Name = "Westleigh",
                Age = 2,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-22.jpg",
                Wins = 36,
                Defeats = 91,
                Games = 127,
                Likes = 705,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2dc3"),
                Name = "Bobby",
                Age = 0,
                FavouriteFood = "Shrike",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-23.jpg",
                Wins = 53,
                Defeats = 82,
                Games = 135,
                Likes = 133,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2dd3"),
                Name = "Karyl",
                Age = 3,
                FavouriteFood = "Indian",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-24.jpg",
                Wins = 48,
                Defeats = 41,
                Games = 89,
                Likes = 95,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2de3"),
                Name = "Meryl",
                Age = 0,
                FavouriteFood = "Waxbill",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-25.jpg",
                Wins = 27,
                Defeats = 40,
                Games = 67,
                Likes = 251,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2df3"),
                Name = "Quillan",
                Age = 0,
                FavouriteFood = "Quillan",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-26.jpg",
                Wins = 35,
                Defeats = 83,
                Games = 118,
                Likes = 598,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2ea3"),
                Name = "Modesty",
                Age = 2,
                FavouriteFood = "Buttermilk",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-27.jpg",
                Wins = 29,
                Defeats = 105,
                Games = 134,
                Likes = 454,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ca-4d15-9494-5244280a2ab3"),
                Name = "Mariette",
                Age = 2,
                FavouriteFood = "Heron",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-28.jpg",
                Wins = 17,
                Defeats = 27,
                Games = 44,
                Likes = 834,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2ec3"),
                Name = "Dorothee",
                Age = 0,
                FavouriteFood = "Kingfisher",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-29.jpg",
                Wins = 68,
                Defeats = 21,
                Games = 89,
                Likes = 969,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590e70-94ce-4d15-9494-5244280a2ee3"),
                Name = "Stevy",
                Age = 1,
                FavouriteFood = "Vulture",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-30.jpg",
                Wins = 50,
                Defeats = 82,
                Games = 132,
                Likes = 275,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590e70-94ce-4d15-9494-5244280a2ef3"),
                Name = "Grayce",
                Age = 1,
                FavouriteFood = "Lizard",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-31.jpg",
                Wins = 35,
                Defeats = 78,
                Games = 113,
                Likes = 479,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590e70-94ce-4d15-9494-5244280a2fa3"),
                Name = "Jaeger",
                Age = 0,
                FavouriteFood = "Jaeger",
                FavouriteActivity = "Jaeger",
                ImageName = "hamster-32.jpg",
                Wins = 68,
                Defeats = 49,
                Games = 117,
                Likes = 971,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ee-4d15-9494-5244280a2fb3"),
                Name = "Gannon",
                Age = 2,
                FavouriteFood = "Weeper",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-33.jpg",
                Wins = 48,
                Defeats = 11,
                Games = 59,
                Likes = 907,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2fc3"),
                Name = "Burton",
                Age = 1,
                FavouriteFood = "Bunting",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-34.jpg",
                Wins = 54,
                Defeats = 87,
                Games = 141,
                Likes = 315,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2fd3"),
                Name = "Kaycee",
                Age = 3,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-35.jpg",
                Wins = 85,
                Defeats = 54,
                Games = 139,
                Likes = 660,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2fe3"),
                Name = "Allix",
                Age = 0,
                FavouriteFood = "Bushbaby",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-36.jpg",
                Wins = 47,
                Defeats = 12,
                Games = 59,
                Likes = 819,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590f70-94ce-4d15-9494-5244280a2ff3"),
                Name = "Herbert",
                Age = 1,
                FavouriteFood = "Alpaca",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-37.jpg",
                Wins = 100,
                Defeats = 70,
                Games = 170,
                Likes = 10,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2fa3"),
                Name = "Ginny",
                Age = 0,
                FavouriteFood = "Fox",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-38.jpg",
                Wins = 71,
                Defeats = 93,
                Games = 164,
                Likes = 402,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2fb3"),
                Name = "Teriann",
                Age = 1,
                FavouriteFood = "Badger",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-39.jpg",
                Wins = 34,
                Defeats = 20,
                Games = 54,
                Likes = 122,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2fc3"),
                Name = "Shelia",
                Age = 3,
                FavouriteFood = "Nothing",
                FavouriteActivity = "Nothing",
                ImageName = "hamster-40.jpg",
                Wins = 84,
                Defeats = 73,
                Games = 157,
                Likes = 76,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2fd3"),
                Name = "Fuling",
                Age = 8,
                FavouriteFood = "Human",
                FavouriteActivity = "Murder",
                ImageName = "hamster-42.jpg",
                Wins = 929,
                Defeats = 5,
                Games = 934,
                Likes = 0,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2fe3"),
                Name = "Evil",
                Age = 2,
                FavouriteFood = "See picture",
                FavouriteActivity = "Dinner",
                ImageName = "hamster-41.jpg",
                Wins = 1007,
                Defeats = 1,
                Games = 1008,
                Likes = 9999,
                Status = "Active"
            },
            new Hamster
            {
                Id = new Guid("3d590a70-94ce-4d15-9494-5244280a2ff3"),
                Name = "test",
                Age = 0,
                FavouriteFood = null,
                FavouriteActivity = null,
                ImageName = "hamster-43.jpg",
                Wins = 0,
                Defeats = 1,
                Games = 1,
                Likes = 0,
                Status = "Deleted"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ce-4d15-9494-5244280a2ea3"),
                Name = "test1",
                Age = 0,
                FavouriteFood = null,
                FavouriteActivity = null,
                ImageName = "hamster-43.jpg",
                Wins = 0,
                Defeats = 1,
                Games = 1,
                Likes = 0,
                Status = "Deleted"
            },
            new Hamster
            {
                Id = new Guid("3d590d70-94ea-4d15-9494-5244280a2ae3"),
                Name = "test2",
                Age = 2,
                FavouriteFood = null,
                FavouriteActivity = null,
                ImageName = "hamster-43.jpg",
                Wins = 0,
                Defeats = 0,
                Games = 0,
                Likes = 0,
                Status = "Deleted"
            }
            );
        }
    }

}
