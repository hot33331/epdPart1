using Newtonsoft.Json;
using Refit;

namespace Todo.Core.Models
{
	public class TodoItem
	{
		// Tables created prior to November 2013 should use 'int' type. Check your configuration.
		
		[JsonProperty(PropertyName = "Id")]
		public string Id { get; set; }
		
		
		[JsonProperty(PropertyName = "Name")]
		public string Text { get; set; }

		
		[JsonProperty(PropertyName = "Done")]
		public bool Complete { get; set; }
	}
}

