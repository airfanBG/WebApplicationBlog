﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20210302131914_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Rating = 5,
                            Url = "http://sample.com",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("Model.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Content = "Test 1",
                            Title = "First post"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Content = "Test 2",
                            Title = "Second post"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 1,
                            Content = "Test 3",
                            Title = "aa post"
                        },
                        new
                        {
                            Id = 4,
                            BlogId = 1,
                            Content = "Test 4",
                            Title = "dasda post"
                        },
                        new
                        {
                            Id = 5,
                            BlogId = 1,
                            Content = "Test 5",
                            Title = "KKK post"
                        },
                        new
                        {
                            Id = 6,
                            BlogId = 1,
                            Content = "Test 6",
                            Title = "BBB post"
                        },
                        new
                        {
                            Id = 7,
                            BlogId = 1,
                            Content = "Test 7",
                            Title = "UOOO post"
                        },
                        new
                        {
                            Id = 8,
                            BlogId = 1,
                            Content = "Test 8",
                            Title = "ERRR post"
                        },
                        new
                        {
                            Id = 9,
                            BlogId = 1,
                            Content = "a092ce03-bb27-4d40-a841-e34a4a2f00e4",
                            Title = "bc772a7e-3375-4c28-b27c-41fdf6e54a9a"
                        },
                        new
                        {
                            Id = 10,
                            BlogId = 1,
                            Content = "7d52b8b8-7a6a-4cdf-b336-9e71e5dcb74d",
                            Title = "32f09cb4-e2f0-40e5-a306-3fc3890d4b19"
                        },
                        new
                        {
                            Id = 11,
                            BlogId = 1,
                            Content = "d9a4290b-a617-4a77-a98a-1e07032eceab",
                            Title = "ed104c1f-1709-458f-9b65-e936d7a8ae0f"
                        },
                        new
                        {
                            Id = 12,
                            BlogId = 1,
                            Content = "25898b1f-38ad-4fd4-9475-ad029122a994",
                            Title = "354a512d-f951-4991-af26-b5d051098c08"
                        },
                        new
                        {
                            Id = 13,
                            BlogId = 1,
                            Content = "8c562a39-06d6-4322-b917-d2b6cac28cd9",
                            Title = "f7059ff5-0ad4-4fff-b61a-c0cad67c942d"
                        },
                        new
                        {
                            Id = 14,
                            BlogId = 1,
                            Content = "07d95548-1e95-4cd1-99bc-2199b8397303",
                            Title = "407a410a-b888-495d-8885-f72b62b5a3af"
                        },
                        new
                        {
                            Id = 15,
                            BlogId = 1,
                            Content = "1cb5d5a5-c8fb-43b3-ac43-be6bb44f2982",
                            Title = "59878cda-d8e7-4476-8a37-1dda392a4916"
                        },
                        new
                        {
                            Id = 16,
                            BlogId = 1,
                            Content = "56fd4210-6fae-4296-ba91-106b02108827",
                            Title = "21c28f61-9537-44f7-979a-aa8a9cb9664a"
                        },
                        new
                        {
                            Id = 17,
                            BlogId = 1,
                            Content = "dd66a6ca-becb-4826-8ef4-6636000f3956",
                            Title = "342c6e92-1f48-404e-b150-d85326360a87"
                        },
                        new
                        {
                            Id = 18,
                            BlogId = 1,
                            Content = "dac97ec3-94a7-43cc-ab78-1c6fa893e816",
                            Title = "69d19b9d-ffaf-44e3-9f0e-835efd6383c5"
                        },
                        new
                        {
                            Id = 19,
                            BlogId = 1,
                            Content = "74e12fbb-ef34-4c06-986a-5bd6af184efd",
                            Title = "4f304471-d88b-4d94-b464-e003b97661a4"
                        },
                        new
                        {
                            Id = 20,
                            BlogId = 1,
                            Content = "689196f1-845b-481b-aa4b-f751e6eb9deb",
                            Title = "39f3b0ec-44d4-4c96-876a-e85f64274614"
                        },
                        new
                        {
                            Id = 21,
                            BlogId = 1,
                            Content = "ee9731cb-c2fc-4686-8283-46fa1f3ea27a",
                            Title = "987ef438-0453-4b42-9784-3dd61deb627c"
                        },
                        new
                        {
                            Id = 22,
                            BlogId = 1,
                            Content = "a007b239-633a-4b1e-8652-995b5625d5a3",
                            Title = "0599b3f5-68f5-417c-b16c-e9a04b54fee9"
                        },
                        new
                        {
                            Id = 23,
                            BlogId = 1,
                            Content = "000d5752-b9c7-404c-b658-635c29823f80",
                            Title = "aad21d94-1df7-4ee5-b714-a5a76df5b602"
                        },
                        new
                        {
                            Id = 24,
                            BlogId = 1,
                            Content = "d9663842-a6e5-4b17-a396-17cb4daa2085",
                            Title = "9c366733-5e3f-46dd-a091-74cf2c409be4"
                        },
                        new
                        {
                            Id = 25,
                            BlogId = 1,
                            Content = "bb3af54d-f3de-4f3d-9541-4ecbebaa1264",
                            Title = "9c78e49d-607e-46fd-8032-54fda4b94cc1"
                        },
                        new
                        {
                            Id = 26,
                            BlogId = 1,
                            Content = "90c26b77-e24b-4930-b850-ade6763771bc",
                            Title = "1aa07210-eccd-4d52-aaf1-24443f790715"
                        },
                        new
                        {
                            Id = 27,
                            BlogId = 1,
                            Content = "01fe0b8c-5c4c-4464-bab3-7cd421fb9edb",
                            Title = "fc61f428-3a5e-4210-a32b-295372058902"
                        },
                        new
                        {
                            Id = 28,
                            BlogId = 1,
                            Content = "87f7fa4e-71cf-4d0c-b71c-e7f3b99c5851",
                            Title = "762a2c84-8a0b-42eb-814f-a51c133980e1"
                        },
                        new
                        {
                            Id = 29,
                            BlogId = 1,
                            Content = "99c217ee-c8b3-405b-9c1d-c6e129340a7c",
                            Title = "de750ac0-6b0c-4aee-9cca-4fd6cf83d86c"
                        },
                        new
                        {
                            Id = 30,
                            BlogId = 1,
                            Content = "5e255b5f-7021-4264-9c25-90a17e0ef03d",
                            Title = "0b18c55a-6617-4eb6-ae8c-dba6cecf5b00"
                        },
                        new
                        {
                            Id = 31,
                            BlogId = 1,
                            Content = "f702b39c-b6e5-48c0-91c8-f18183614228",
                            Title = "7fbeaed8-0efb-414e-b370-2a6988237da1"
                        },
                        new
                        {
                            Id = 32,
                            BlogId = 1,
                            Content = "b4040ca5-d88f-46a7-a832-78554c7e27af",
                            Title = "5c0465aa-6d5f-4b56-a8d2-93c3a6745c61"
                        },
                        new
                        {
                            Id = 33,
                            BlogId = 1,
                            Content = "85a7d459-62da-410c-a4de-611091c2a1e3",
                            Title = "b231e3fc-97d2-4cb9-8835-59a8b2680c82"
                        },
                        new
                        {
                            Id = 34,
                            BlogId = 1,
                            Content = "0d788840-a022-4ceb-8d07-27c968da0689",
                            Title = "2973f65c-a332-420a-8f39-87725e1e6149"
                        },
                        new
                        {
                            Id = 35,
                            BlogId = 1,
                            Content = "7c2f0281-7792-4d4d-84a1-af3edebc03e7",
                            Title = "39369167-0f11-4749-be4d-fa3c65b76c8e"
                        },
                        new
                        {
                            Id = 36,
                            BlogId = 1,
                            Content = "d4a3bd78-47d6-4ef8-951b-f44d51cc70b1",
                            Title = "da76c55c-df22-4227-9f31-e9e0e8a9cfc9"
                        },
                        new
                        {
                            Id = 37,
                            BlogId = 1,
                            Content = "59abf7b2-7f3e-4890-8f4b-8bb893250cdd",
                            Title = "fc41c8c3-40be-446f-b84e-4a882497a37e"
                        },
                        new
                        {
                            Id = 38,
                            BlogId = 1,
                            Content = "d62e9f0b-4576-451f-a5d7-b4e57cf346cd",
                            Title = "cc207a51-cf54-47e7-8da9-5a9d353cbbd7"
                        },
                        new
                        {
                            Id = 39,
                            BlogId = 1,
                            Content = "1125047b-5693-45fc-84cc-b99941ba0271",
                            Title = "7d6935f3-2db4-4d61-9e67-721ba3d429a4"
                        },
                        new
                        {
                            Id = 40,
                            BlogId = 1,
                            Content = "e9ee8895-46d8-45e6-bcde-cf26e0ef07e9",
                            Title = "019f5d9e-c80c-4633-b2b2-9298438e2080"
                        },
                        new
                        {
                            Id = 41,
                            BlogId = 1,
                            Content = "b74b9b68-b33c-4838-931b-b2cf66ef3d71",
                            Title = "3937d2d2-c8ad-455e-b3ab-b181b3170811"
                        },
                        new
                        {
                            Id = 42,
                            BlogId = 1,
                            Content = "5305ca2f-7a02-4e9e-8290-35cba8ed5776",
                            Title = "f2a4df9c-83ba-47fa-9560-a19a92a9a2a9"
                        },
                        new
                        {
                            Id = 43,
                            BlogId = 1,
                            Content = "7fb459d5-037a-47ac-b8f8-4c0b3e28a536",
                            Title = "1df93e7f-5dc7-49c2-893b-67a9e15eae70"
                        },
                        new
                        {
                            Id = 44,
                            BlogId = 1,
                            Content = "f9068c16-2ad1-431a-8df7-f9290eba87bb",
                            Title = "bcb4a8b3-d886-4671-9f2f-a35adbe1be88"
                        },
                        new
                        {
                            Id = 45,
                            BlogId = 1,
                            Content = "8cb43e74-ad4a-423b-a5d9-236d18c58f92",
                            Title = "730661e8-6dfc-410c-9207-b33943878498"
                        },
                        new
                        {
                            Id = 46,
                            BlogId = 1,
                            Content = "b06bb6d0-bf86-411a-81c3-afbe7ebe6ef3",
                            Title = "208f64c5-675f-46bb-a1ed-05ca90746c91"
                        },
                        new
                        {
                            Id = 47,
                            BlogId = 1,
                            Content = "b3cebce1-3386-4a2b-9a75-6b343f82d73e",
                            Title = "7bde5555-2cdf-4c77-8943-f20532267f45"
                        },
                        new
                        {
                            Id = 48,
                            BlogId = 1,
                            Content = "525c0481-37f6-4b96-b553-8d1e65449e7a",
                            Title = "bf103413-0a88-4984-87d1-718935441404"
                        },
                        new
                        {
                            Id = 49,
                            BlogId = 1,
                            Content = "d9b276f6-8d74-4358-b621-4dd5d0967b59",
                            Title = "0fe541a3-49c9-491a-ac17-eaed602dcf0b"
                        },
                        new
                        {
                            Id = 50,
                            BlogId = 1,
                            Content = "c3d54f82-ecb4-4230-a852-51559cb921b6",
                            Title = "49a66fb0-5d1a-4b7f-a1eb-7c21b7fdb3f1"
                        },
                        new
                        {
                            Id = 51,
                            BlogId = 1,
                            Content = "2913439e-47df-4775-a326-20d4546956f7",
                            Title = "f490fba5-6475-4c4c-a889-896d71683719"
                        },
                        new
                        {
                            Id = 52,
                            BlogId = 1,
                            Content = "aa8f8af6-ea2e-4865-b0f5-90927c01e6a7",
                            Title = "ce0a8b1b-a3ef-4705-9678-bc3960a17a3a"
                        },
                        new
                        {
                            Id = 53,
                            BlogId = 1,
                            Content = "5c31d807-1b27-41f4-8b57-37811dc5c0fe",
                            Title = "c15ae6d0-9422-4f2f-af9f-f67ef46b867d"
                        },
                        new
                        {
                            Id = 54,
                            BlogId = 1,
                            Content = "bb507f87-9a3d-4dfa-8090-9b5b6c816709",
                            Title = "da2542fb-47ca-4f42-8a7b-5b06327652f0"
                        },
                        new
                        {
                            Id = 55,
                            BlogId = 1,
                            Content = "e18acad2-6cac-46f2-97e0-135b3aa160e5",
                            Title = "e0380d79-e4b2-4481-9efc-e718b73b5a83"
                        },
                        new
                        {
                            Id = 56,
                            BlogId = 1,
                            Content = "88c361ae-c4e1-49ae-88e3-e7f8a3d69757",
                            Title = "c5fb4b5e-268f-4a06-b7cf-8cccc4f098df"
                        },
                        new
                        {
                            Id = 57,
                            BlogId = 1,
                            Content = "438a96e5-da81-4825-b35a-6abcafd48429",
                            Title = "a30362e9-1b93-4cc9-8ff6-4e7038d57f1c"
                        },
                        new
                        {
                            Id = 58,
                            BlogId = 1,
                            Content = "16538465-efbc-4f3c-84bd-93d1aa143e1e",
                            Title = "af35d6e0-c02e-459a-bbd7-4f6bb8fcae8b"
                        },
                        new
                        {
                            Id = 59,
                            BlogId = 1,
                            Content = "3ea7f65a-29d6-4037-a203-40bcc66b68ca",
                            Title = "a63883ee-ca37-4136-9989-2301ad54b6f9"
                        },
                        new
                        {
                            Id = 60,
                            BlogId = 1,
                            Content = "2e82bb47-7fde-44fc-a63f-e02707d5cdb5",
                            Title = "6d319c46-82bf-4fc6-8b41-5dd57f6944d0"
                        },
                        new
                        {
                            Id = 61,
                            BlogId = 1,
                            Content = "f925926f-930b-4bca-b043-eb9983b61ffb",
                            Title = "5d0f0f36-10db-4fff-8e1f-ca4d5dc84303"
                        },
                        new
                        {
                            Id = 62,
                            BlogId = 1,
                            Content = "cac854ea-aa4f-4b1c-abf8-a9b63d139af2",
                            Title = "af873921-e353-4585-9c69-01bbe9d28974"
                        },
                        new
                        {
                            Id = 63,
                            BlogId = 1,
                            Content = "992394c2-05bf-4283-b7b1-7a3dc8f88c22",
                            Title = "49f7ca9b-f9eb-4266-b8ec-08f79ac97547"
                        },
                        new
                        {
                            Id = 64,
                            BlogId = 1,
                            Content = "346f9412-3608-4e31-839f-a3b61c6e5565",
                            Title = "58b77d16-31b5-46b6-8355-8575420db16a"
                        },
                        new
                        {
                            Id = 65,
                            BlogId = 1,
                            Content = "5455b5bc-6d38-4004-a9bf-526f332d3791",
                            Title = "db30428c-53a0-4c8d-b327-1159f47ba56b"
                        },
                        new
                        {
                            Id = 66,
                            BlogId = 1,
                            Content = "aabfcf99-19d1-448b-8596-d5f3e6448020",
                            Title = "c120e568-5f8b-49af-8e82-8571c3391da1"
                        },
                        new
                        {
                            Id = 67,
                            BlogId = 1,
                            Content = "e2c8b6ff-85d4-476c-b4ee-f5ea150e33b0",
                            Title = "a0bec252-c394-4ca1-820e-4fa7ae3f0816"
                        },
                        new
                        {
                            Id = 68,
                            BlogId = 1,
                            Content = "34ccd8ea-154c-4e31-bc2f-7d0ce689425d",
                            Title = "be7618d3-f2a7-4721-925a-0dd7aebaeb1f"
                        },
                        new
                        {
                            Id = 69,
                            BlogId = 1,
                            Content = "9cf59def-ed36-4275-a342-8059b7c6474e",
                            Title = "c6c9d199-b6c5-4316-8082-a9a9662000b1"
                        },
                        new
                        {
                            Id = 70,
                            BlogId = 1,
                            Content = "a8f66d74-5178-417a-a81a-f6a03ba99d4a",
                            Title = "7fc576fb-ba20-42f8-8967-07b1d9a70de9"
                        },
                        new
                        {
                            Id = 71,
                            BlogId = 1,
                            Content = "bcff7bf7-a69b-4899-aead-c869f82427c2",
                            Title = "f0230c29-8975-43a4-a1d5-8245437b1d85"
                        },
                        new
                        {
                            Id = 72,
                            BlogId = 1,
                            Content = "5badb832-b122-473a-993f-9430f3c2ad04",
                            Title = "7b110d23-49d1-4de5-8bf7-c8a8804fff6b"
                        },
                        new
                        {
                            Id = 73,
                            BlogId = 1,
                            Content = "df16a220-497d-4370-8660-fb1cb2a416c1",
                            Title = "033e9106-82bb-4ab6-abeb-b270c99ba233"
                        },
                        new
                        {
                            Id = 74,
                            BlogId = 1,
                            Content = "ac7a1de0-33cd-4abf-bb46-246eb47a6cff",
                            Title = "e5a3f3ba-81bb-4f8a-8971-2a4052fb4f50"
                        },
                        new
                        {
                            Id = 75,
                            BlogId = 1,
                            Content = "c971a2fa-a842-430c-8b01-c9a05279eac4",
                            Title = "4449a6a7-2646-4f9d-bd7c-e4e98ea3f467"
                        },
                        new
                        {
                            Id = 76,
                            BlogId = 1,
                            Content = "dcf2dc06-6191-46eb-922a-4cb4a398128d",
                            Title = "54337c29-a35b-45c5-b863-f29d6b4886d4"
                        },
                        new
                        {
                            Id = 77,
                            BlogId = 1,
                            Content = "8a794762-17a0-4d30-9e3f-242ea4491f30",
                            Title = "a5edee74-2920-4fe4-9fb2-2cd5ebb22df2"
                        },
                        new
                        {
                            Id = 78,
                            BlogId = 1,
                            Content = "801a158a-752d-47d7-84f2-ad9698815bfb",
                            Title = "f1c3f69e-c083-4f14-9a03-23ec5858dc12"
                        },
                        new
                        {
                            Id = 79,
                            BlogId = 1,
                            Content = "84e5bcf1-c51e-41f4-9e7f-61b2da791eb6",
                            Title = "8c107866-a0d9-48b7-ad87-7778b64bca6e"
                        },
                        new
                        {
                            Id = 80,
                            BlogId = 1,
                            Content = "1f4c9cc5-7b2d-4c5e-a54b-5ac98950c194",
                            Title = "daf897bc-0bf2-44dd-b841-c1cf39dc1f6c"
                        },
                        new
                        {
                            Id = 81,
                            BlogId = 1,
                            Content = "c0033190-14dd-4cf1-9e54-ae22e5460832",
                            Title = "affccee9-0da1-4142-aa15-a0376ce593fb"
                        },
                        new
                        {
                            Id = 82,
                            BlogId = 1,
                            Content = "5d37d774-00b8-4f47-9d7a-74d4a7e9958c",
                            Title = "cc99836d-1b3c-48fd-ad33-6cf04603e093"
                        },
                        new
                        {
                            Id = 83,
                            BlogId = 1,
                            Content = "e0884b93-1922-41a0-9e72-e791a29c4b67",
                            Title = "c9de975d-1458-4992-a3ef-d8ea700e2f1b"
                        },
                        new
                        {
                            Id = 84,
                            BlogId = 1,
                            Content = "bbc2e280-099c-4083-88b8-e3403a74682d",
                            Title = "6e776ff5-0ab8-4c8e-91dc-ccaa3c62fbb8"
                        },
                        new
                        {
                            Id = 85,
                            BlogId = 1,
                            Content = "b1cc9830-0ee3-47fd-99bb-51fd81398300",
                            Title = "752e5a31-87f5-436f-abe5-d3a9aca5a36d"
                        },
                        new
                        {
                            Id = 86,
                            BlogId = 1,
                            Content = "0073fc40-b6f4-4660-9543-c74b2c817379",
                            Title = "d1a423af-348a-4b9e-aabb-b3ac1ab58085"
                        },
                        new
                        {
                            Id = 87,
                            BlogId = 1,
                            Content = "e19d374e-7abb-4328-9cf4-1878977df0a9",
                            Title = "04036022-cc75-4c7a-a161-51180f059595"
                        },
                        new
                        {
                            Id = 88,
                            BlogId = 1,
                            Content = "d111de0e-08b0-4014-b7e7-5c5c8a854957",
                            Title = "62bb2e8a-c4ff-45ac-84ff-06708ab7dc46"
                        },
                        new
                        {
                            Id = 89,
                            BlogId = 1,
                            Content = "c119665b-29d7-4b37-bc61-2f3b02ba4306",
                            Title = "bd5ae690-f357-4b22-85c4-6ecd9399ff43"
                        },
                        new
                        {
                            Id = 90,
                            BlogId = 1,
                            Content = "061ea391-5799-4f99-af52-48c3683a1054",
                            Title = "96ebf981-035a-4874-8de8-f5a8d113af9d"
                        },
                        new
                        {
                            Id = 91,
                            BlogId = 1,
                            Content = "2a84ee19-58e1-4f0c-9140-ff196fbf2a9f",
                            Title = "718f9945-9282-4f14-ad64-fd183b35dcb1"
                        },
                        new
                        {
                            Id = 92,
                            BlogId = 1,
                            Content = "a0ebf884-c91f-4c45-bbad-0027f4bee9a2",
                            Title = "ea3ff8c0-0c03-4fc0-b580-be40900a6267"
                        },
                        new
                        {
                            Id = 93,
                            BlogId = 1,
                            Content = "8c75ab28-4f91-4756-bbe8-fd1bf03e8a75",
                            Title = "04e1a9d6-0368-453a-addb-113dc6bf5827"
                        },
                        new
                        {
                            Id = 94,
                            BlogId = 1,
                            Content = "46542470-10c8-494e-9be0-b37bfff75c81",
                            Title = "d9310538-5c3e-4d33-bd7e-77d37a457ba4"
                        },
                        new
                        {
                            Id = 95,
                            BlogId = 1,
                            Content = "8959211a-bda8-49ec-8227-7772c6873e80",
                            Title = "9c8146ca-5c5e-4354-82c4-fc7a0cf0d179"
                        },
                        new
                        {
                            Id = 96,
                            BlogId = 1,
                            Content = "86ea3241-c581-479b-b972-74bd638f4326",
                            Title = "540d3014-0cca-42dd-af62-78315e0633f5"
                        },
                        new
                        {
                            Id = 97,
                            BlogId = 1,
                            Content = "41589fbd-79cc-41cb-91e8-4f3f23347231",
                            Title = "2781791c-864e-401d-8c31-0040262b5dfd"
                        },
                        new
                        {
                            Id = 98,
                            BlogId = 1,
                            Content = "ca3d6751-199f-4b31-9d29-9b0c814355f6",
                            Title = "8d96c9a8-6d95-41e1-b2b0-3d0fcb5f17ef"
                        },
                        new
                        {
                            Id = 99,
                            BlogId = 1,
                            Content = "7d912a7a-e96c-41d1-b2bb-e4e85f8e5db2",
                            Title = "9fde8cdd-b8b4-4398-b9a6-e82df13ea3e3"
                        });
                });

            modelBuilder.Entity("Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("Model.Blog", b =>
                {
                    b.HasOne("Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Post", b =>
                {
                    b.HasOne("Model.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("Model.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Blog", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
