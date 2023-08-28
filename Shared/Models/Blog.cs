using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared.Models
{
	public class Blog
	{
		public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public string Url { get; set; }
		public string ImageUrl { get; set; }
		public string Category { get; set; }
		public string Tags { get; set; }
		public BlogContent Content { get; set; }
		public List<BlogComment> Comments { get; set; }
		public List<BlogLike> Likes { get; set; }
		public List<BlogRating> Ratings { get; set; }
		public List<BlogShare> Shares { get; set; }
		public List<BlogView> Views { get; set; }
		public List<BlogImage> Images { get; set; }

		public List<BlogVideo> Videos { get; set; }
		
		public BlogTemplate Template { get; set; }

	}
}
