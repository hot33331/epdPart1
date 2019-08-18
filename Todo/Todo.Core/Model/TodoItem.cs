using Newtonsoft.Json;

namespace Todo.Core.Model
{
	public class TodoItem
	{
		// Tables created prior to November 2013 should use 'int' type. Check your configuration.
		public string Id { get; set; }

		[JsonProperty(PropertyName = "Name")]
		public string Text { get; set; }

		[JsonProperty(PropertyName = "Done")]
		public bool Complete { get; set; }
	}
}

