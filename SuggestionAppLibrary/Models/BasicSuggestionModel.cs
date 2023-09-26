namespace SuggestionAppLibrary.Models;
public class BasicSuggestionModel
{
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }
   public string Suggetion { get; set; }

   public BasicSuggestionModel()
   {

   }

   public BasicSuggestionModel(SuggestionModel suggestion)
   {
      Id = suggestion.Id;
      Suggetion = suggestion.Suggestion;
   }
}
