using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
	public class Issue
	{
		public Guid IssueId { get; set; }

		[Required]
		public string Subject { get; set; }

		[Required]
		public string Body { get; set; }

		[Required]
		public bool Pending { get; set; } = false;
	}
}