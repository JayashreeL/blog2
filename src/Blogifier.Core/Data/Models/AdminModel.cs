﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Blogifier.Core.Data.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogifier.Core.Data.Models
{
	public class AdminBaseModel
    {
		public Profile Profile { get; set; }
		public bool BlogExists { get { return Profile != null; }  }
    }

	public class AdminPostsModel : AdminBaseModel
	{
        public BlogPost SelectedPost { get; set; }
		public IEnumerable<BlogPost> BlogPosts { get; set; }
	}

	public class AdminProfileModel : AdminBaseModel
	{
		public IList<SelectListItem> BlogThemes { get; set; }
    }

	public class AdminSyndicationModel : AdminBaseModel
	{
		public int ProfileId { get; set; }
		[Required]
		[StringLength(450)]
		public string FeedUrl { get; set; }
		[StringLength(150)]
		public string Domain { get; set; }
		[StringLength(150)]
		public string SubDomain { get; set; }

		public bool ImportImages { get; set; }
		public bool ImportAttachements { get; set; }
	}

    public class PostEditModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<int> Categories { get; set; }
        public bool Published { get; set; }
    }

    public class CategoryItem
    {
        public string Id { get; set; }
        [Required]
        [StringLength(160)]
        public string Title { get; set; }
        [StringLength(450)]
        public string Description { get; set; }
        public string Slug { get; set; }
        public int ViewCount { get; set; }
        public int PostCount { get; set; }
        public bool Selected { get; set; }
    }
}
