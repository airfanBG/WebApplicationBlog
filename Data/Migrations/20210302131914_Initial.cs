using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Rating", "Url", "UserId", "UserId1" },
                values: new object[] { 1, 5, "http://sample.com", 0, null });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "Tag", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Test 1", null, "First post" },
                    { 72, 1, "5badb832-b122-473a-993f-9430f3c2ad04", null, "7b110d23-49d1-4de5-8bf7-c8a8804fff6b" },
                    { 71, 1, "bcff7bf7-a69b-4899-aead-c869f82427c2", null, "f0230c29-8975-43a4-a1d5-8245437b1d85" },
                    { 70, 1, "a8f66d74-5178-417a-a81a-f6a03ba99d4a", null, "7fc576fb-ba20-42f8-8967-07b1d9a70de9" },
                    { 69, 1, "9cf59def-ed36-4275-a342-8059b7c6474e", null, "c6c9d199-b6c5-4316-8082-a9a9662000b1" },
                    { 68, 1, "34ccd8ea-154c-4e31-bc2f-7d0ce689425d", null, "be7618d3-f2a7-4721-925a-0dd7aebaeb1f" },
                    { 67, 1, "e2c8b6ff-85d4-476c-b4ee-f5ea150e33b0", null, "a0bec252-c394-4ca1-820e-4fa7ae3f0816" },
                    { 66, 1, "aabfcf99-19d1-448b-8596-d5f3e6448020", null, "c120e568-5f8b-49af-8e82-8571c3391da1" },
                    { 65, 1, "5455b5bc-6d38-4004-a9bf-526f332d3791", null, "db30428c-53a0-4c8d-b327-1159f47ba56b" },
                    { 64, 1, "346f9412-3608-4e31-839f-a3b61c6e5565", null, "58b77d16-31b5-46b6-8355-8575420db16a" },
                    { 63, 1, "992394c2-05bf-4283-b7b1-7a3dc8f88c22", null, "49f7ca9b-f9eb-4266-b8ec-08f79ac97547" },
                    { 62, 1, "cac854ea-aa4f-4b1c-abf8-a9b63d139af2", null, "af873921-e353-4585-9c69-01bbe9d28974" },
                    { 61, 1, "f925926f-930b-4bca-b043-eb9983b61ffb", null, "5d0f0f36-10db-4fff-8e1f-ca4d5dc84303" },
                    { 60, 1, "2e82bb47-7fde-44fc-a63f-e02707d5cdb5", null, "6d319c46-82bf-4fc6-8b41-5dd57f6944d0" },
                    { 59, 1, "3ea7f65a-29d6-4037-a203-40bcc66b68ca", null, "a63883ee-ca37-4136-9989-2301ad54b6f9" },
                    { 58, 1, "16538465-efbc-4f3c-84bd-93d1aa143e1e", null, "af35d6e0-c02e-459a-bbd7-4f6bb8fcae8b" },
                    { 57, 1, "438a96e5-da81-4825-b35a-6abcafd48429", null, "a30362e9-1b93-4cc9-8ff6-4e7038d57f1c" },
                    { 56, 1, "88c361ae-c4e1-49ae-88e3-e7f8a3d69757", null, "c5fb4b5e-268f-4a06-b7cf-8cccc4f098df" },
                    { 55, 1, "e18acad2-6cac-46f2-97e0-135b3aa160e5", null, "e0380d79-e4b2-4481-9efc-e718b73b5a83" },
                    { 54, 1, "bb507f87-9a3d-4dfa-8090-9b5b6c816709", null, "da2542fb-47ca-4f42-8a7b-5b06327652f0" },
                    { 53, 1, "5c31d807-1b27-41f4-8b57-37811dc5c0fe", null, "c15ae6d0-9422-4f2f-af9f-f67ef46b867d" },
                    { 52, 1, "aa8f8af6-ea2e-4865-b0f5-90927c01e6a7", null, "ce0a8b1b-a3ef-4705-9678-bc3960a17a3a" },
                    { 73, 1, "df16a220-497d-4370-8660-fb1cb2a416c1", null, "033e9106-82bb-4ab6-abeb-b270c99ba233" },
                    { 51, 1, "2913439e-47df-4775-a326-20d4546956f7", null, "f490fba5-6475-4c4c-a889-896d71683719" },
                    { 74, 1, "ac7a1de0-33cd-4abf-bb46-246eb47a6cff", null, "e5a3f3ba-81bb-4f8a-8971-2a4052fb4f50" },
                    { 76, 1, "dcf2dc06-6191-46eb-922a-4cb4a398128d", null, "54337c29-a35b-45c5-b863-f29d6b4886d4" },
                    { 97, 1, "41589fbd-79cc-41cb-91e8-4f3f23347231", null, "2781791c-864e-401d-8c31-0040262b5dfd" },
                    { 96, 1, "86ea3241-c581-479b-b972-74bd638f4326", null, "540d3014-0cca-42dd-af62-78315e0633f5" },
                    { 95, 1, "8959211a-bda8-49ec-8227-7772c6873e80", null, "9c8146ca-5c5e-4354-82c4-fc7a0cf0d179" },
                    { 94, 1, "46542470-10c8-494e-9be0-b37bfff75c81", null, "d9310538-5c3e-4d33-bd7e-77d37a457ba4" },
                    { 93, 1, "8c75ab28-4f91-4756-bbe8-fd1bf03e8a75", null, "04e1a9d6-0368-453a-addb-113dc6bf5827" },
                    { 92, 1, "a0ebf884-c91f-4c45-bbad-0027f4bee9a2", null, "ea3ff8c0-0c03-4fc0-b580-be40900a6267" },
                    { 91, 1, "2a84ee19-58e1-4f0c-9140-ff196fbf2a9f", null, "718f9945-9282-4f14-ad64-fd183b35dcb1" },
                    { 90, 1, "061ea391-5799-4f99-af52-48c3683a1054", null, "96ebf981-035a-4874-8de8-f5a8d113af9d" },
                    { 89, 1, "c119665b-29d7-4b37-bc61-2f3b02ba4306", null, "bd5ae690-f357-4b22-85c4-6ecd9399ff43" },
                    { 88, 1, "d111de0e-08b0-4014-b7e7-5c5c8a854957", null, "62bb2e8a-c4ff-45ac-84ff-06708ab7dc46" },
                    { 87, 1, "e19d374e-7abb-4328-9cf4-1878977df0a9", null, "04036022-cc75-4c7a-a161-51180f059595" },
                    { 86, 1, "0073fc40-b6f4-4660-9543-c74b2c817379", null, "d1a423af-348a-4b9e-aabb-b3ac1ab58085" },
                    { 85, 1, "b1cc9830-0ee3-47fd-99bb-51fd81398300", null, "752e5a31-87f5-436f-abe5-d3a9aca5a36d" },
                    { 84, 1, "bbc2e280-099c-4083-88b8-e3403a74682d", null, "6e776ff5-0ab8-4c8e-91dc-ccaa3c62fbb8" },
                    { 83, 1, "e0884b93-1922-41a0-9e72-e791a29c4b67", null, "c9de975d-1458-4992-a3ef-d8ea700e2f1b" },
                    { 82, 1, "5d37d774-00b8-4f47-9d7a-74d4a7e9958c", null, "cc99836d-1b3c-48fd-ad33-6cf04603e093" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "Tag", "Title" },
                values: new object[,]
                {
                    { 81, 1, "c0033190-14dd-4cf1-9e54-ae22e5460832", null, "affccee9-0da1-4142-aa15-a0376ce593fb" },
                    { 80, 1, "1f4c9cc5-7b2d-4c5e-a54b-5ac98950c194", null, "daf897bc-0bf2-44dd-b841-c1cf39dc1f6c" },
                    { 79, 1, "84e5bcf1-c51e-41f4-9e7f-61b2da791eb6", null, "8c107866-a0d9-48b7-ad87-7778b64bca6e" },
                    { 78, 1, "801a158a-752d-47d7-84f2-ad9698815bfb", null, "f1c3f69e-c083-4f14-9a03-23ec5858dc12" },
                    { 77, 1, "8a794762-17a0-4d30-9e3f-242ea4491f30", null, "a5edee74-2920-4fe4-9fb2-2cd5ebb22df2" },
                    { 75, 1, "c971a2fa-a842-430c-8b01-c9a05279eac4", null, "4449a6a7-2646-4f9d-bd7c-e4e98ea3f467" },
                    { 98, 1, "ca3d6751-199f-4b31-9d29-9b0c814355f6", null, "8d96c9a8-6d95-41e1-b2b0-3d0fcb5f17ef" },
                    { 50, 1, "c3d54f82-ecb4-4230-a852-51559cb921b6", null, "49a66fb0-5d1a-4b7f-a1eb-7c21b7fdb3f1" },
                    { 48, 1, "525c0481-37f6-4b96-b553-8d1e65449e7a", null, "bf103413-0a88-4984-87d1-718935441404" },
                    { 22, 1, "a007b239-633a-4b1e-8652-995b5625d5a3", null, "0599b3f5-68f5-417c-b16c-e9a04b54fee9" },
                    { 21, 1, "ee9731cb-c2fc-4686-8283-46fa1f3ea27a", null, "987ef438-0453-4b42-9784-3dd61deb627c" },
                    { 20, 1, "689196f1-845b-481b-aa4b-f751e6eb9deb", null, "39f3b0ec-44d4-4c96-876a-e85f64274614" },
                    { 19, 1, "74e12fbb-ef34-4c06-986a-5bd6af184efd", null, "4f304471-d88b-4d94-b464-e003b97661a4" },
                    { 18, 1, "dac97ec3-94a7-43cc-ab78-1c6fa893e816", null, "69d19b9d-ffaf-44e3-9f0e-835efd6383c5" },
                    { 17, 1, "dd66a6ca-becb-4826-8ef4-6636000f3956", null, "342c6e92-1f48-404e-b150-d85326360a87" },
                    { 16, 1, "56fd4210-6fae-4296-ba91-106b02108827", null, "21c28f61-9537-44f7-979a-aa8a9cb9664a" },
                    { 15, 1, "1cb5d5a5-c8fb-43b3-ac43-be6bb44f2982", null, "59878cda-d8e7-4476-8a37-1dda392a4916" },
                    { 14, 1, "07d95548-1e95-4cd1-99bc-2199b8397303", null, "407a410a-b888-495d-8885-f72b62b5a3af" },
                    { 13, 1, "8c562a39-06d6-4322-b917-d2b6cac28cd9", null, "f7059ff5-0ad4-4fff-b61a-c0cad67c942d" },
                    { 12, 1, "25898b1f-38ad-4fd4-9475-ad029122a994", null, "354a512d-f951-4991-af26-b5d051098c08" },
                    { 11, 1, "d9a4290b-a617-4a77-a98a-1e07032eceab", null, "ed104c1f-1709-458f-9b65-e936d7a8ae0f" },
                    { 10, 1, "7d52b8b8-7a6a-4cdf-b336-9e71e5dcb74d", null, "32f09cb4-e2f0-40e5-a306-3fc3890d4b19" },
                    { 9, 1, "a092ce03-bb27-4d40-a841-e34a4a2f00e4", null, "bc772a7e-3375-4c28-b27c-41fdf6e54a9a" },
                    { 8, 1, "Test 8", null, "ERRR post" },
                    { 7, 1, "Test 7", null, "UOOO post" },
                    { 6, 1, "Test 6", null, "BBB post" },
                    { 5, 1, "Test 5", null, "KKK post" },
                    { 4, 1, "Test 4", null, "dasda post" },
                    { 3, 1, "Test 3", null, "aa post" },
                    { 2, 1, "Test 2", null, "Second post" },
                    { 23, 1, "000d5752-b9c7-404c-b658-635c29823f80", null, "aad21d94-1df7-4ee5-b714-a5a76df5b602" },
                    { 49, 1, "d9b276f6-8d74-4358-b621-4dd5d0967b59", null, "0fe541a3-49c9-491a-ac17-eaed602dcf0b" },
                    { 24, 1, "d9663842-a6e5-4b17-a396-17cb4daa2085", null, "9c366733-5e3f-46dd-a091-74cf2c409be4" },
                    { 26, 1, "90c26b77-e24b-4930-b850-ade6763771bc", null, "1aa07210-eccd-4d52-aaf1-24443f790715" },
                    { 47, 1, "b3cebce1-3386-4a2b-9a75-6b343f82d73e", null, "7bde5555-2cdf-4c77-8943-f20532267f45" },
                    { 46, 1, "b06bb6d0-bf86-411a-81c3-afbe7ebe6ef3", null, "208f64c5-675f-46bb-a1ed-05ca90746c91" },
                    { 45, 1, "8cb43e74-ad4a-423b-a5d9-236d18c58f92", null, "730661e8-6dfc-410c-9207-b33943878498" },
                    { 44, 1, "f9068c16-2ad1-431a-8df7-f9290eba87bb", null, "bcb4a8b3-d886-4671-9f2f-a35adbe1be88" },
                    { 43, 1, "7fb459d5-037a-47ac-b8f8-4c0b3e28a536", null, "1df93e7f-5dc7-49c2-893b-67a9e15eae70" },
                    { 42, 1, "5305ca2f-7a02-4e9e-8290-35cba8ed5776", null, "f2a4df9c-83ba-47fa-9560-a19a92a9a2a9" },
                    { 41, 1, "b74b9b68-b33c-4838-931b-b2cf66ef3d71", null, "3937d2d2-c8ad-455e-b3ab-b181b3170811" },
                    { 40, 1, "e9ee8895-46d8-45e6-bcde-cf26e0ef07e9", null, "019f5d9e-c80c-4633-b2b2-9298438e2080" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "Tag", "Title" },
                values: new object[,]
                {
                    { 39, 1, "1125047b-5693-45fc-84cc-b99941ba0271", null, "7d6935f3-2db4-4d61-9e67-721ba3d429a4" },
                    { 38, 1, "d62e9f0b-4576-451f-a5d7-b4e57cf346cd", null, "cc207a51-cf54-47e7-8da9-5a9d353cbbd7" },
                    { 37, 1, "59abf7b2-7f3e-4890-8f4b-8bb893250cdd", null, "fc41c8c3-40be-446f-b84e-4a882497a37e" },
                    { 36, 1, "d4a3bd78-47d6-4ef8-951b-f44d51cc70b1", null, "da76c55c-df22-4227-9f31-e9e0e8a9cfc9" },
                    { 35, 1, "7c2f0281-7792-4d4d-84a1-af3edebc03e7", null, "39369167-0f11-4749-be4d-fa3c65b76c8e" },
                    { 34, 1, "0d788840-a022-4ceb-8d07-27c968da0689", null, "2973f65c-a332-420a-8f39-87725e1e6149" },
                    { 33, 1, "85a7d459-62da-410c-a4de-611091c2a1e3", null, "b231e3fc-97d2-4cb9-8835-59a8b2680c82" },
                    { 32, 1, "b4040ca5-d88f-46a7-a832-78554c7e27af", null, "5c0465aa-6d5f-4b56-a8d2-93c3a6745c61" },
                    { 31, 1, "f702b39c-b6e5-48c0-91c8-f18183614228", null, "7fbeaed8-0efb-414e-b370-2a6988237da1" },
                    { 30, 1, "5e255b5f-7021-4264-9c25-90a17e0ef03d", null, "0b18c55a-6617-4eb6-ae8c-dba6cecf5b00" },
                    { 29, 1, "99c217ee-c8b3-405b-9c1d-c6e129340a7c", null, "de750ac0-6b0c-4aee-9cca-4fd6cf83d86c" },
                    { 28, 1, "87f7fa4e-71cf-4d0c-b71c-e7f3b99c5851", null, "762a2c84-8a0b-42eb-814f-a51c133980e1" },
                    { 27, 1, "01fe0b8c-5c4c-4464-bab3-7cd421fb9edb", null, "fc61f428-3a5e-4210-a32b-295372058902" },
                    { 25, 1, "bb3af54d-f3de-4f3d-9541-4ecbebaa1264", null, "9c78e49d-607e-46fd-8032-54fda4b94cc1" },
                    { 99, 1, "7d912a7a-e96c-41d1-b2bb-e4e85f8e5db2", null, "9fde8cdd-b8b4-4398-b9a6-e82df13ea3e3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId1",
                table: "Blogs",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagsId",
                table: "PostTag",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
