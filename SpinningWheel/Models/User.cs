using System;
namespace SpinningWheel.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedDateTime { get; set; }
	}

	public class Main
	{
		public User user { get; set; }
		public int userCount { get; set; }
		public int videoWatched { get; set; }
    }
}

