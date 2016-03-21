using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class CharacterInitializer : DropCreateDatabaseIfModelChanges<MiddleEarthContext>
	{
		protected override void Seed(MiddleEarthContext context)
		{
			var characters = new List<Character>
			{
				new Character
				{
					FirstName = "Bilbo",
					LastName = "Baggins",
					Address = "#3 Bag End",
					City = "Hobbiton",
					Age = 111,
					Interests = "Writing",
					RaceId = 1,
					RegionId = 1,

				},
				new Character
				{
					FirstName = "Frodo",
					LastName = "Baggins",
					Address = "#3 Bag End",
					City = "Hobbiton",
					Age = 55,
					Interests = "Cooking",
					RaceId = 1,
					RegionId = 1
				},
				new Character
				{
					FirstName = "Sam",
					LastName = "Gamgee",
					Address = "#6 Bagshot Row",
					City = "Hobbiton",
					Age = 45,
					Interests = "Gardening",
					RaceId = 1,
					RegionId = 1
				},
				new Character
				{
					FirstName = "Meridoc",
					LastName = "Brandybuck",
					Address = "Brandy Hall",
					City = "Buckleberry",
					Age = 35,
					Interests = "Horseback riding",
					RaceId = 1,
					RegionId = 1
				},
				new Character
				{
					FirstName = "Peregrin",
					LastName = "Took",
					Address = "Great Smials",
					City = "Tuckborough",
					Age = 35,
					Interests = "Pipeweed",
					RaceId = 1,
					RegionId = 1
				},
				new Character
				{
					FirstName = "Aragorn",
					LastName = "Elessar",
					Address = "Royal Palace",
					City = "Minas Tirith",
					Age = 85,
					Interests = "Fencing",
					RaceId = 3,
					RegionId = 4
				},
				new Character
				{
					FirstName = "Eomer",
					LastName = "Eadig",
					Address = "The Mark",
					City = "Eodoras",
					Age = 40,
					Interests = "Horseback Riding",
					RaceId = 3,
					RegionId = 5
				},
				new Character
				{
					FirstName = "Gandalf",
					LastName = "Grey",
					Address = "Cottage #3",
					City = "Imladris",
					Age = 4000,
					Interests = "Fireworks",
					RaceId = 6,
					RegionId = 2
				},
				new Character
				{
					FirstName = "Gimli",
					LastName = "Gloinson",
					Address = "Glittering Caves",
					City = "Helms Deep",
					Age = 285,
					Interests = "Precious Gems",
					RaceId = 4,
					RegionId = 5
				},
				new Character
				{
					FirstName = "Legolas",
					LastName = "Thranduilson",
					Address = "Thranduil's Palace",
					City = "Mirkwood",
					Age = 366,
					Interests = "Archery",
					RaceId = 2,
					RegionId = 7
				},
				new Character
				{
					FirstName = "Elrond",
					LastName = "Half-elven",
					Address = "Main Palace",
					City = "Imladris",
					Age = 3350,
					Interests = "History",
					RaceId = 2,
					RegionId = 2
				}
			};

			characters.ForEach(s => context.Characters.Add(s));
			context.SaveChanges();

			var races = new List<Race>
			{
				new Race {Id = 1,Name = "Hobbit"},
				new Race {Id = 2, Name = "Elves"},
				new Race {Id = 3,Name = "Men"},
				new Race {Id = 4,Name = "Dwarves"},
				new Race {Id = 5,Name = "Ent"},
				new Race {Id = 6,Name = "Wizard"},
				new Race {Id = 7, Name = "Orc"},
				new Race {Id = 8,Name = "Necomancer"}
			};

			races.ForEach(s => context.Races.Add(s));
			context.SaveChanges();

			var regions = new List<Region>
			{
				new Region {Id = 1, Name = "Shire"},
				new Region {Id = 2,Name = "Rivendale"},
				new Region {Id = 3,Name = "Lothlorien"},
				new Region {Id = 4,Name = "Gondor"},
				new Region {Id = 5,Name = "Rohan"},
				new Region {Id = 6, Name = "Mordor"},
				new Region {Id = 7,Name = "Eregion"},
				new Region {Id = 8,Name = "Mirkwood"},
				new Region {Id = 9,Name = "Lonely Mountain"}
			};

			regions.ForEach(s => context.Regions.Add(s));
			context.SaveChanges();
		}
	}
}
