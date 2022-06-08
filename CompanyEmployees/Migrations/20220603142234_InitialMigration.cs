using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsV2API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Winner_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Loser_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    HamsterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavouriteFood = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FavouriteActivity = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.HamsterId);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavouriteActivity", "FavouriteFood", "Games", "ImageName", "Likes", "Name", "Status", "Wins" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5244280c2ce3"), 1, 32, "Nothing", "Nothing", 71, "hamster-1.jpg", 348, "Haskel", "Active", 39 },
                    { new Guid("3d590a70-64ce-4d15-9494-5244280a2be3"), 1, 44, "Nothing", "Boar", 52, "hamster-14.jpg", 93, "Danny", "Active", 8 },
                    { new Guid("3d590a70-94aa-4d15-9494-5244280a2ae3"), 1, 82, "Nothing", "Cow", 166, "hamster-4.jpg", 38, "Ruttger", "Active", 84 },
                    { new Guid("3d590a70-94be-4d15-9494-5244280a2cb3"), 3, 45, "Nothing", "Koala", 104, "hamster-17.jpg", 496, "Kittie", "Active", 59 },
                    { new Guid("3d590a70-94ce-4d15-9094-5244280a2ca3"), 2, 51, "Nothing", "Hoffman", 96, "hamster-16.jpg", 291, "Mariellen", "Active", 45 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2aa3"), 2, 35, "Nothing", "Nothing", 115, "hamster-5.jpg", 689, "Eleanor", "Active", 80 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2cc3"), 3, 91, "Nothing", "Eagle", 111, "hamster-18.jpg", 329, "Steffi", "Active", 20 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2ce3"), 0, 8, "Nothing", "Chestnut", 97, "hamster-3.jpg", 595, "Jedediah", "Active", 89 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2fa3"), 0, 93, "Nothing", "Fox", 164, "hamster-38.jpg", 402, "Ginny", "Active", 71 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2fb3"), 1, 20, "Nothing", "Badger", 54, "hamster-39.jpg", 122, "Teriann", "Active", 34 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2fc3"), 3, 73, "Nothing", "Nothing", 157, "hamster-40.jpg", 76, "Shelia", "Active", 84 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2fd3"), 8, 5, "Murder", "Human", 934, "hamster-42.jpg", 0, "Fuling", "Active", 929 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2fe3"), 2, 1, "Dinner", "See picture", 1008, "hamster-41.jpg", 9999, "Evil", "Active", 1007 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280a2ff3"), 0, 1, null, null, 1, "hamster-43.jpg", 0, "test", "Deleted", 0 },
                    { new Guid("3d590a70-94ce-4d15-9494-5244280c2ce3"), 1, 29, "Nothing", "Beaver", 124, "hamster-2.jpg", 553, "Shanon", "Active", 95 },
                    { new Guid("3d590a70-94ce-4d15-9494-5245280a2bc3"), 2, 12, "Nothing", "Warthog", 29, "hamster-13.jpg", 889, "Vevay", "Active", 17 },
                    { new Guid("3d590a70-94ce-4d15-9794-5244280a2ab3"), 2, 56, "Nothing", "Skunk", 109, "hamster-6.jpg", 690, "Aggi", "Active", 53 },
                    { new Guid("3d590a70-94ce-5d15-9494-5244280a2bb3"), 3, 37, "Nothing", "Snake", 102, "hamster-12.jpg", 619, "Gregorius", "Active", 65 },
                    { new Guid("3d590a74-94ce-4d15-9494-5244280a2ba3"), 2, 24, "Nothing", "Owl", 59, "hamster-11.jpg", 945, "Bogart", "Active", 35 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2ce3"), 0, 39, "Nothing", "Duck", 50, "hamster-19.jpg", 26, "Phedra", "Active", 11 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2da3"), 1, 74, "Nothing", "Nothing", 139, "hamster-21.jpg", 252, "Lilla", "Active", 65 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2db3"), 2, 91, "Nothing", "Nothing", 127, "hamster-22.jpg", 705, "Westleigh", "Active", 36 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2dc3"), 0, 82, "Nothing", "Shrike", 135, "hamster-23.jpg", 133, "Bobby", "Active", 53 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2dd3"), 3, 41, "Nothing", "Indian", 89, "hamster-24.jpg", 95, "Karyl", "Active", 48 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2de3"), 0, 40, "Nothing", "Waxbill", 67, "hamster-25.jpg", 251, "Meryl", "Active", 27 },
                    { new Guid("3d590d70-94ce-4d15-9494-5244280a2ea3"), 0, 1, null, null, 1, "hamster-43.jpg", 0, "test1", "Deleted", 0 },
                    { new Guid("3d590d70-94ea-4d15-9494-5244280a2ae3"), 2, 0, null, null, 0, "hamster-43.jpg", 0, "test2", "Deleted", 0 },
                    { new Guid("3d590e70-94ce-4d15-9494-5244280a2ae3"), 2, 22, "Nothing", "Jaguar", 77, "hamster-9.jpg", 990, "Rick", "Active", 55 },
                    { new Guid("3d590e70-94ce-4d15-9494-5244280a2cf3"), 2, 91, "Nothing", "Squirrel", 188, "hamster-20.jpg", 598, "Artemas", "Active", 97 },
                    { new Guid("3d590e70-94ce-4d15-9494-5244280a2ee3"), 1, 82, "Nothing", "Vulture", 132, "hamster-30.jpg", 275, "Stevy", "Active", 50 },
                    { new Guid("3d590e70-94ce-4d15-9494-5244280a2ef3"), 1, 78, "Nothing", "Lizard", 113, "hamster-31.jpg", 479, "Grayce", "Active", 35 },
                    { new Guid("3d590e70-94ce-4d15-9494-5244280a2fa3"), 0, 49, "Jaeger", "Jaeger", 117, "hamster-32.jpg", 971, "Jaeger", "Active", 68 },
                    { new Guid("3d590f70-94ca-4d15-9494-5244280a2ab3"), 2, 27, "Nothing", "Heron", 44, "hamster-28.jpg", 834, "Mariette", "Active", 17 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2df3"), 0, 83, "Nothing", "Quillan", 118, "hamster-26.jpg", 598, "Quillan", "Active", 35 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2ea3"), 2, 105, "Nothing", "Buttermilk", 134, "hamster-27.jpg", 454, "Modesty", "Active", 29 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2ec3"), 0, 21, "Nothing", "Kingfisher", 89, "hamster-29.jpg", 969, "Dorothee", "Active", 68 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2fc3"), 1, 87, "Nothing", "Bunting", 141, "hamster-34.jpg", 315, "Burton", "Active", 54 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2fd3"), 3, 54, "Nothing", "Nothing", 139, "hamster-35.jpg", 660, "Kaycee", "Active", 85 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2fe3"), 0, 12, "Nothing", "Bushbaby", 59, "hamster-36.jpg", 819, "Allix", "Active", 47 },
                    { new Guid("3d590f70-94ce-4d15-9494-5244280a2ff3"), 1, 70, "Nothing", "Alpaca", 170, "hamster-37.jpg", 10, "Herbert", "Active", 100 },
                    { new Guid("3d590f70-94ee-4d15-9494-5244280a2fb3"), 2, 11, "Nothing", "Weeper", 59, "hamster-33.jpg", 907, "Gannon", "Active", 48 },
                    { new Guid("3d598a70-94cf-4d15-9494-5244280a2af3"), 3, 4, "Nothing", "Caribou", 28, "hamster-10.jpg", 133, "Tova", "Active", 24 }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavouriteActivity", "FavouriteFood", "Games", "ImageName", "Likes", "Name", "Status", "Wins" },
                values: new object[] { new Guid("3d890a70-94ce-4d15-9494-5244280a2ad3"), 3, 69, "Nothing", "Frogmouth", 94, "hamster-8.jpg", 748, "Jackquelin", "Active", 25 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavouriteActivity", "FavouriteFood", "Games", "ImageName", "Likes", "Name", "Status", "Wins" },
                values: new object[] { new Guid("3d990a70-94ce-4d15-9494-5244280a2bf3"), 3, 23, "Nothing", "Iguana", 122, "hamster-15.jpg", 627, "Davide", "Active", 99 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavouriteActivity", "FavouriteFood", "Games", "ImageName", "Likes", "Name", "Status", "Wins" },
                values: new object[] { new Guid("3f590a70-94ce-4d15-9494-5244280a2ac3"), 2, 105, "Nothing", "Sloth", 155, "hamster-7.jpg", 394, "Wally", "Active", 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
